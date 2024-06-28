using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    [CreateAssetMenu(fileName = "Country")]
    public class CountrySO : ScriptableObject
    {

        [SerializeField]
        public string Country;
        [SerializeField]
        public float TotalPopulation;
        [SerializeField]
        public int TotalGold;
        [SerializeField]
        public int TotalFood;
        [SerializeField]
        public ProvinceSO[] ProvinceList;
       

    }
   
}
