using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseMarket : MonoBehaviour {


    public int NumberOfPlanets = 10;
    int NumberOfResources = 9;
    int[,] Planets;


    public UniverseMarket() {
        Planets = new int[NumberOfPlanets, NumberOfResources];

    }


    public void MarketsStart()
    {
        System.Random rand = new System.Random();


        int rarity;

        

        int consumptionRateBase;
        int consumptionRateBaseTotal;

        int consumptionRate;
        int consumptionRateTotal;

        int avarage;

        for (int i = 0; i < NumberOfResources; i++)
        {

            if (i < 4)
            {
                rarity = 2;
            }
            else if (i < 7)
            {
                rarity = 3;
            }
            else
            {
                rarity = 5;
            }

            consumptionRateBaseTotal = 0;

            for (int j = 0; j < NumberOfPlanets; j++)
            {

                int min = 25;
                int max = 75;

                if (j == 0)
                {
                    consumptionRateBase = 0;
                } else
                {
                    avarage = consumptionRateBaseTotal / j;

                    if (avarage > 50)
                    {
                        max = avarage;
                    } else if (avarage < 50)
                    {
                        min = avarage;
                    }
                }


                consumptionRateBase = rand.Next(min, max);
                consumptionRateBaseTotal += consumptionRateBase;

                double modRarity = System.Math.Pow(rarity, 1.5);



                consumptionRate = (int)(consumptionRateBase * 3 / modRarity);

                if (j == 2 && i == 8)
                {

                    Debug.Log(rarity);

                    Debug.Log(modRarity);

                    Debug.Log(consumptionRateBase);
                    Debug.Log(consumptionRate);


                }

                Planets[j, i] = consumptionRate;

            }
        }
    }

    // Use this for initialization
    void Start () {
        MarketsStart();
        Debug.Log(Planets[2,8]);

    }

    // Update is called once per frame
    void Update () {

    }
}
