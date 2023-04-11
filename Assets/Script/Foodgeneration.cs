using FoodSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Foodgeneration : MonoBehaviour
{
	// Start is called before the first frame update
	public TextMeshProUGUI dishnumber1;
	public TextMeshProUGUI dishnumber2;
	public TextMeshProUGUI dishnumber4;
    public TextMeshProUGUI dishnumber5;

    public TextMeshProUGUI rounddown;
    public TextMeshProUGUI rounddown2;
    public static string finaldish = "";
    public static string finaldish2 = "";

    int Maindish;
    int Maindish2;

	private static int counter1 = 0;
	private static int counter2 = 0;

    void Start()
    {
		buttondown();
        buttondown2();
    }

    // Update is called once per frame
    void Update()
    {
		movestepdown();
		if (GameStage.g) {
			GameStage.g=false;
		}
		if (CalculateScore.complateCook)
		{
			CalculateScore.complateCook = false;
        }
	}


	public void movestepdown() {
		if (( Input.GetKeyDown(KeyCode.W) ) || ( Input.GetKeyDown(KeyCode.A) ) || ( Input.GetKeyDown(KeyCode.S) ) || ( Input.GetKeyDown(KeyCode.D) )) {
			counter1--;
			counter2--;
			rounddown.text = counter1 + "";
            rounddown2.text = counter2 + "";
            buttondown();
            buttondown2();

        }
	} 

	public void buttondown() {
		if (counter1 <= 0)
		{
			Maindish = Random.Range(0, 2);
			int ChooseArray = Random.Range(1, 4);
            counter1 = 15;
            switch (ChooseArray)
			{
				case 1:
					dishnumber1.text = FoodStack.grilledFood[Maindish] + "";
					finaldish = FoodStack.grilledFood[Maindish];
					if (Maindish == 0)
					{
						
						dishnumber2.text = FoodStack.foodName[0];
					}
					else if (Maindish == 1)
					{
                        dishnumber2.text = FoodStack.foodName[1];
					}
					break;

				case 2:
					dishnumber1.text = FoodStack.panFood[Maindish] + "";
					finaldish = FoodStack.panFood[Maindish];
					if (Maindish == 0)
					{
                        dishnumber2.text = FoodStack.foodName[2];

					}
					else if (Maindish == 1)
					{
                        dishnumber2.text = FoodStack.foodName[3];
					}
					break;

				case 3:
					dishnumber1.text = FoodStack.cutFood[Maindish] + "";
					finaldish = FoodStack.cutFood[Maindish];
					if (Maindish == 0)
					{
                        dishnumber2.text = FoodStack.foodName[4];

					}
					else if (Maindish == 1)
					{
                        dishnumber2.text = FoodStack.foodName[5];
					}
					break;

			}
		}
		
        rounddown.text = "Hand Within Turns: " + counter1 + "";
		

    }
    public void buttondown2()
    {
        if (counter2 <= 0)
        {
            counter2 = 10;
            Maindish2 = Random.Range(0, 2);
            int ChooseArray2 = Random.Range(1, 4);
            switch (ChooseArray2)
            {
                case 1:
                    dishnumber4.text = FoodStack.grilledFood[Maindish2] + "";
                    finaldish2 = FoodStack.grilledFood[Maindish2];
                    if (Maindish2 == 0)
                    {
                        
                        dishnumber5.text = FoodStack.foodName[0];

                    }
                    else if (Maindish2 == 1)
                    {
                        dishnumber5.text = FoodStack.foodName[1];
                    }
                    break;

                case 2:
                    dishnumber4.text = FoodStack.panFood[Maindish2] + "";
                    finaldish2 = FoodStack.panFood[Maindish2];
                    if (Maindish2 == 0)
                    {
                        dishnumber5.text = FoodStack.foodName[2];
                    }
                    else if (Maindish2 == 1)
                    {
                        dishnumber5.text = FoodStack.foodName[3];
                    }
                    break;

                case 3:
                    dishnumber4.text = FoodStack.cutFood[Maindish2] + "";
                    finaldish2 = FoodStack.cutFood[Maindish2];
                    if (Maindish2 == 0)
                    {
                        dishnumber5.text = FoodStack.foodName[4];
                    }
                    else if (Maindish2 == 1)
                    {
                        dishnumber5.text = FoodStack.foodName[5];
                    }
                    break;
            }
        }
        rounddown2.text = "Hand Within Turns: " + counter2 + "";
    }






}
