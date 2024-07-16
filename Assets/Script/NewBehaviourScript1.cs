using Assets.Script.Data;
using Assets.Script.SO;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assembly_CSharp
{
    public class NewBehaviourScript1 : MonoBehaviour
    {
        public List<Province> province;
        System.Random random = new System.Random();
        public ProvinceSO[] provinceSO;

        // Use this for initialization
        void Start()
        {

            province = GameObject.FindObjectsOfType<Province>().ToList<Province>();
            foreach (var pro in province)
            {
                pro.provinceSO.Country = pro.Country;
                switch (pro.provinceSO.ProvinceLevel)
                {
                    case 1:
                        setGoldIncome(pro.provinceSO, 100, 200);
                        setPopulation(pro.provinceSO, 1000, 9999);
                        pro.provinceSO.FoodCost = 1;
                        pro.provinceSO.FoodIncome = 2;
                        pro.provinceSO.GoldCost = 90;
                        break;
                    case 2:
                        setGoldIncome(pro.provinceSO, 200, 300);
                        setPopulation(pro.provinceSO, 10000, 19999);
                        pro.provinceSO.FoodIncome = 5;
                        pro.provinceSO.FoodCost = 2;
                        pro.provinceSO.GoldCost = 180;
                        break;
                    case 3:
                        setGoldIncome(pro.provinceSO, 300, 400);
                        setPopulation(pro.provinceSO, 20000, 29999);
                        pro.provinceSO.FoodIncome = 7;
                        pro.provinceSO.FoodCost = 4;
                        pro.provinceSO.GoldCost = 270;
                        break;
                    case 4:
                        setGoldIncome(pro.provinceSO, 400, 500);
                        setPopulation(pro.provinceSO, 30000, 39999);
                        pro.provinceSO.FoodIncome = 10;
                        pro.provinceSO.FoodCost = 8;
                        pro.provinceSO.GoldCost = 360;
                        break;
                    case 5:
                        setGoldIncome(pro.provinceSO, 500, 600);
                        setPopulation(pro.provinceSO, 40000, 49999);
                        pro.provinceSO.FoodIncome = 14;
                        pro.provinceSO.FoodCost = 10;
                        pro.provinceSO.GoldCost = 450;
                        break;

                }

                pro.provinceSO.Security = 60;
            }


        }
        public void setGoldIncome(ProvinceSO pro, int min, int max)
        {
            pro.GoldIncome = (float)(System.Math.Round((double)random.Next(min, max)) / 10) * 10;
        }
        public void setPopulation(ProvinceSO pro, int min, int max)
        {
            pro.Population = (float)System.Math.Round((double)random.Next(min, max));
        }

    }
}