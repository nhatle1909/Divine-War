﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
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


     
        public CountrySO[] CountryList;

        public void Start()
        {
            CountryList = Resources.LoadAll<CountrySO>("");
        }
        public void NextTurnButton() 
        {
            // Loop for each country in country list
            foreach ( var Country in CountryList) 
            {

                Country.TotalPopulation = 0;
                // loop for each province in a country
                foreach ( var province in Country.ProvinceList ) 
                {
                    // Update Country Scriptable Object data and Province Scriptable Object data
                    Country.TotalGold = Country.TotalGold + province.GoldIncome - province.GoldCost;
                    Country.TotalGold = Country.TotalFood + province.FoodIncome - province.FoodCost;
                    province.Population = Mathf.Ceil(province.Population * 101 / 100);
                    Country.TotalPopulation = Country.TotalPopulation + province.Population; 
                    
                    if (!PlayerCulture.Equals(province.Culture))
                    {
                        province.Security -= 1;
                    }
                    SecurityEffect(province);
                } 
            }
         
            // Increase current turn
            CurrentTurn += 1;
            //Update information of player country in next turn
            UpdateCountryCanvasUI();
        }

        public void UpdateCountryCanvasUI() 
        {
            CountrySO playerCountrySO = CountryList.First(a => a.Country.Equals(PlayerCountry));
            TotalPopulation.SetText(playerCountrySO.TotalPopulation.ToString());
            TotalGold.SetText(playerCountrySO.TotalGold.ToString());
            TotalGold.SetText(playerCountrySO.TotalFood.ToString());
        }
        public void SecurityEffect(Province pro)
        {
            if (pro.Security <= 0)
            {
                return;
            }
            if (pro.Security < 20)
            {
                return;
            }
            if (pro.Security < 40)
            {
                return;
            }
           
        }
        public void Save()
        {

        }

    }
}
