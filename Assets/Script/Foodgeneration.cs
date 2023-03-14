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
	public TextMeshProUGUI dishnumber3;
	public TextMeshProUGUI dishnumber4;
	public TextMeshProUGUI rounddown;
	bool reroll = false;

	int Maindish;
	int combodish;

	int counter=5;
	


	void Start()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
		movestepdown();

		}
	void rerollpressed() {
		reroll = true;
	}

	public void movestepdown() {
		if (( Input.GetKeyDown(KeyCode.W) ) || ( Input.GetKeyDown(KeyCode.A) ) || ( Input.GetKeyDown(KeyCode.S) ) || ( Input.GetKeyDown(KeyCode.D) )) {
			counter--;
			rounddown.text = counter + "";
			buttondown();
		}
	} 

	public void buttondown() {

		if (counter <= 0||reroll==true) {
			Maindish = Random.Range(0,2);
			combodish= Random.Range(0,3);
			int ChooseArray = Random.Range(1,5);
			reroll = false;
			Debug.Log(ChooseArray + "ssss1");


			switch (ChooseArray) {
				case 1:
					dishnumber1.text = FoodStack.grilledFood [Maindish] + "";

					if (Maindish == 0) {
						dishnumber2.text = FoodStack.foodName [0];
						dishnumber3.text = "";
						dishnumber4.text = "";
					}
					else if (Maindish == 1) {
						dishnumber2.text = FoodStack.foodName [1];
						dishnumber3.text = "";
						dishnumber4.text = "";
					}
					break;

				case 2:
					dishnumber1.text = FoodStack.panFood [Maindish] + "";

					if (Maindish == 0) {
						dishnumber2.text = FoodStack.foodName [2];
						dishnumber3.text = "";
						dishnumber4.text = "";
					}
					else if (Maindish == 1) {
						dishnumber2.text = FoodStack.foodName [3];
						dishnumber3.text = "";
						dishnumber4.text = "";
					}
					break;

				case 3:
					dishnumber1.text = FoodStack.cutFood [Maindish] + "";
					if (Maindish == 0) {
						dishnumber2.text = FoodStack.foodName [4];
						dishnumber3.text = "";
						dishnumber4.text = "";
					}
					else if (Maindish == 1) {
						dishnumber2.text = FoodStack.foodName [5];
						dishnumber3.text = "";
						dishnumber4.text = "";
					}
					break;

				case 4:
					dishnumber1.text = FoodStack.combo [combodish] + "";

					if (combodish == 0) {
						dishnumber2.text = FoodStack.grilledFood [0];
						dishnumber3.text = FoodStack.grilledFood [1];
						dishnumber4.text = FoodStack.cutFood[1];
					}
					else if (combodish == 1) {
						dishnumber2.text = FoodStack.panFood [0];
						dishnumber3.text = FoodStack.panFood [1];
						dishnumber4.text = FoodStack.cutFood [0];
					}

					else if (combodish == 2) {
						dishnumber2.text = FoodStack.grilledFood [0];
						dishnumber3.text = FoodStack.cutFood [1];
						dishnumber4.text = "";
					}
					break;

			}

				

		


			counter = 5;
		}
		rounddown.text = counter + "";

	}
	

	
		


	

}
