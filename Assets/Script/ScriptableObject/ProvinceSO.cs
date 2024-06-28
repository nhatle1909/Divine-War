using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    [CreateAssetMenu(fileName = "Province")]
    public class ProvinceSO : ScriptableObject
    {
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

    }
    [System.Serializable]
    public class ProvinceBuilding
    {


        public BuildingNames BuildingName;

        public int BuildingCost;

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
