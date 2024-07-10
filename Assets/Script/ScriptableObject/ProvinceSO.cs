using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    [CreateAssetMenu(fileName = "Province")]
    public class ProvinceSO : ScriptableObject
    {
        [SerializeField]
        public int ProvinceLevel;
        [SerializeField]
        public float Population;
        [SerializeField]
        public float GoldIncome;
        [SerializeField]
        public float FoodIncome;
        [SerializeField]
        public float GoldCost;
        [SerializeField]
        public float FoodCost;
        [SerializeField]
        public float BuildingSlot;
     
        [SerializeField]
        public float Security;
        [SerializeField]
        public string Culture;
        [SerializeField]
        public string ProvinceColor;
        [SerializeField]
        public List<ProvinceBuilding> ProvinceBuilding;

       

    }
    [System.Serializable]
    public class ProvinceBuilding
    {


        public BuildingNames BuildingName;

        public float BuildingCost;

        public enum BuildingNames
        {
            House,
            Market,
            Castle,
            MilitaryPost,
            Farm
        }

    }
  
    
}
