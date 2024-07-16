using Assets.Script.Interface;
using Assets.Script.SO;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Script.Data
{
    public class Country : MonoBehaviour, IDataHandler
    {
        [SerializeField]
        public float TotalPopulation;
        [SerializeField]
        public float TotalGold = 0;
        [SerializeField]
        public float TotalFood = 0;
        [SerializeField]
        public Province[] ProvinceList;
        [SerializeField]
        public CountrySO CountrySO;
     
        // Use this for initialization
        void Start()
        {
            
            Load();
            Invoke("GetProvinceList", (float) 0.3);
        }
        public void GetProvinceList()
        {
            ProvinceList = GameObject.FindObjectsOfType<Province>().Where(p=>p.Country.Equals(gameObject.name)).ToArray(); 
        }
            public void Load() // Finished
        {
            TotalPopulation = CountrySO.TotalPopulation;
            TotalGold = CountrySO.TotalGold;
            TotalFood = CountrySO.TotalFood;
            
        }


        public void Save() // Finished
        {
            CountrySO.TotalPopulation = TotalPopulation;
            CountrySO.TotalGold = TotalGold;
            CountrySO.TotalFood = TotalFood;
            CountrySO.ProvinceList = ProvinceList;
        }
        public void UpdateNextTurn()
        {
            TotalFood = 0;
            TotalPopulation = 0;
            
            foreach (var province in ProvinceList)
            {
                TotalGold = TotalGold + province.GoldIncome - province.GoldCost;
                TotalFood = TotalFood + province.FoodIncome - province.FoodCost;
                TotalPopulation = TotalPopulation + province.Population;
            }
        }
    }
}