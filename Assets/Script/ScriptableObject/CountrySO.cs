using Assets.Script.Data;
using UnityEngine;

namespace Assets.Script.SO
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

        public Province[] ProvinceList ;
        
        


    }

}
