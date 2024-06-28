using TMPro;
using UnityEngine;

using UnityEngine.UIElements;

namespace Assets.Script
{

    // This class is used to update information of Canvas UI 
    public class CanvasHandler : MonoBehaviour
    {
        public Image ProvinceInfor;
        public TextMeshProUGUI ProvinceName;
        public TextMeshProUGUI Country;
        public TextMeshProUGUI Population;
        public TextMeshProUGUI GoldIncome;
        public TextMeshProUGUI FoodIncome;
        public TextMeshProUGUI GoldCost;
        public TextMeshProUGUI FoodCost;



        public Province province;
        private Camera mainCamera;

        private void Start()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
            {
                Vector2 clickPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

                if (hit.collider != null && hit.collider.gameObject.GetComponent<SpriteRenderer>() != null)
                {
                    // Clicked on a sprite!

                    province = hit.collider.gameObject.GetComponent<Province>();
                   
                    UpdateCanvas();
                }
            }
        }

        public void UpdateCanvas()
        {// Update Canvas UI based data from Province game component
            
            
            ProvinceName.SetText(province.ProvinceName);
            Country.SetText(province.Country);
            Population.SetText("Population : "  + province.Population.ToString());
            GoldIncome.SetText("Gold Income : " + province.GoldIncome.ToString());
            FoodIncome.SetText("Food Income : " + province.FoodIncome.ToString());
            GoldCost.SetText("Gold Expense : "  + province.GoldCost.ToString());
            FoodCost.SetText("Food Expense : "  + province.FoodCost.ToString());
        }

     
    }
}
