using Assets.Script.Interface;
using Assets.Script.SO;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Data
{
    public class Province : MonoBehaviour, IDataHandler
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
        public int Security;
        [SerializeField]
        public float GoldIncome;
        [SerializeField]
        public float FoodIncome;
        [SerializeField]
        public float GoldCost;
        [SerializeField]
        public float FoodCost;
        [SerializeField]
        public int BuildingSlot;
        [SerializeField]
        public List<ProvinceBuilding> ProvinceBuilding;

        public ProvinceSO provinceSO;


        public void Start()
        {
            Load();
        }


        public void Load() // Finished
        {
            ProvinceName = gameObject.name;
            Country = transform.parent.name;
            Population = provinceSO.Population;
            Security = provinceSO.Security;
            Culture = provinceSO.Culture;
            GoldCost = provinceSO.GoldCost;
            FoodCost = provinceSO.FoodCost;
            GoldIncome = provinceSO.GoldIncome;
            FoodIncome = provinceSO.FoodIncome;
            BuildingSlot = provinceSO.BuildingSlot;
            ProvinceBuilding = provinceSO.ProvinceBuilding;
        }
        public void Save() // Finished
        {
            provinceSO.Population = Population;
            provinceSO.Security = Security;
            provinceSO.Culture = Culture;
            provinceSO.GoldCost = GoldCost;
            provinceSO.GoldIncome = GoldIncome;
            provinceSO.FoodIncome = FoodIncome;
            provinceSO.FoodCost = FoodCost;
            provinceSO.ProvinceBuilding = ProvinceBuilding;
        }

        public void UpdateNextTurn() // Not Finished
        {
            Population = Mathf.CeilToInt(Population * 101 / 100);

        }
    }
}