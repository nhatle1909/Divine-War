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
        public float TotalGold;
        [SerializeField]
        public float TotalFood;
        [SerializeField]
        public Province[] ProvinceList;
       

    }
   
}
