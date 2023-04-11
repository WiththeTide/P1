using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;
using FoodSystem;
using TMPro;

public class CuttingBoard : MonoBehaviour
{
    public bool playerOn = false;
    private int workTime;
    private int CookatTurn;
    public static string currentCooking = " ";
    private int[] cookTime = new int[1];
    private bool finishCut;
    public TMP_Text info;
    public TMP_Text infoF;
    public TMP_Text currentFood;
    // Start is called before the first frame update
    void Start()
    {
        //currentFood.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
       controlTheBoard();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerOn = true;
        infoF.text = "CuttingBoard: ";
        FoodStack.allControl = true;
        if (FoodStack.allControl)
        {
            currentFood.text = currentCooking;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerOn = false;
        infoF.text = string.Empty;
        FoodStack.allControl = false;
        if (!FoodStack.allControl) 
        {
            currentFood.text = string.Empty;
        }
    }
    private void OnMouseEnter()
    {
        info.text = "This is Cutting Board";
    }

    private void OnMouseExit()
    {
        info.text = string.Empty;
    }

    void controlTheBoard()
    {
        CookatTurn = Player.turns;
        if (playerOn == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (finishCut && Player.pocket.Equals(" "))
            {
                Player.pocket = currentCooking;
                currentCooking = " ";
                finishCut = false;
            }

            if (Player.pocket.Equals(FoodStack.foodName[4]))
            {
                workTime = 1;
                CookatTurn = Player.turns + workTime;
                cookTime[0] = CookatTurn;
                Debug.Log(CookatTurn);
                currentCooking = FoodStack.foodName[4];
                Player.pocket = " ";
                Food.emptyPocket();
            }
            else if (Player.pocket.Equals(FoodStack.foodName[5]))
            {
                workTime = 2;
                CookatTurn = Player.turns + workTime;
                cookTime[0] = CookatTurn;
                Debug.Log(CookatTurn);
                currentCooking = FoodStack.foodName[5];
                Player.pocket = " ";
                Food.emptyPocket();
            }
            else
            {
                Debug.Log("You Cannot Do that");
                return;
            }
        }

        bool check = Player.turns.Equals(cookTime[0]);
        //Debug.Log(check);
        if (currentCooking.Equals(FoodStack.foodName[4]) && check)
        {
            currentCooking = FoodStack.cutFood[0];
            finishCut = true;
            cookTime[0] = 0;
            Debug.Log(currentCooking);
        }
        else if (currentCooking.Equals(FoodStack.foodName[5]) && check)
        {
            currentCooking = FoodStack.cutFood[1];
            finishCut = true;
            cookTime[0] = 0;
            Debug.Log(currentCooking);
        }
    }
}
