using Assets.Script.Data;
using System.Linq;
using TMPro;
using UnityEngine;

namespace Assets.Script
{
    public class GameManager : MonoBehaviour
    {
        public int CurrentTurn = 0;

        public string PlayerCountry;
        string PlayerCulture;
        public TextMeshProUGUI TotalPopulation;
        public TextMeshProUGUI TotalGold;
        public TextMeshProUGUI TotalFood;



        public Country[] CountryList;

        public void Start()
        {
            CountryList = GameObject.FindObjectsOfType<Country>();
        }
        public void NextTurnButton()
        {
            // Loop for each country in country list
            foreach (var Country in CountryList)
            {
                //Loop for each province in country
                foreach (var province in Country.ProvinceList)
                {
                    // Update data in next turn of province
                    province.UpdateNextTurn();
                }
                //Update data in next turn of Country
                Country.UpdateNextTurn();

            }
            
            // Increase current turn
            CurrentTurn += 1;
            //Update information of player country in next turn
            Debug.Log(CurrentTurn);

        }
        //Not Finished
        public void UpdateCountryCanvasUI()
        {
            Country playerCountry = CountryList.First(a => a.gameObject.name.Equals(PlayerCountry));
            TotalPopulation.SetText(playerCountry.TotalPopulation.ToString());
            TotalGold.SetText(playerCountry.TotalGold.ToString());
            TotalGold.SetText(playerCountry.TotalFood.ToString());
        }



    }
}
