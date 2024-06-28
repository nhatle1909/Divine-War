using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class Province : MonoBehaviour
    {
        [SerializeField]
        public string ProvinceName;
        [SerializeField]
        public string Country;
        [SerializeField]
        public float Population;
        [SerializeField]
        public string Culture;
        [SerializeField]
        public int GoldIncome;
        [SerializeField]
        public int FoodIncome;
        [SerializeField]
        public int GoldCost;
        [SerializeField]
        public int FoodCost;
        [SerializeField]
        public int BuildingSlot;
        [SerializeField]
        public List<ProvinceBuilding> ProvinceBuilding;

        public ProvinceSO provinceSO;

        public void Awake()
        {
            Init();
        }
        public void Init()
        {
            ProvinceName = gameObject.name;
            Country = transform.parent.name;
            Population = provinceSO.Population;
            Culture = provinceSO.Culture;
            GoldCost = provinceSO.GoldCost;
            FoodCost = provinceSO.FoodCost;
            GoldIncome = provinceSO.GoldIncome;
            FoodIncome = provinceSO.FoodIncome;
            BuildingSlot = provinceSO.BuildingSlot;
            ProvinceBuilding = provinceSO.ProvinceBuilding;
        }
    }
}