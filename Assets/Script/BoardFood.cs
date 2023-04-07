using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FoodSystem;
using player;

public class BoardFood : MonoBehaviour
{
    // Start is called before the first frame
    public FoodStack cutfood;

    [SerializeField]
    private SpriteRenderer boardFood;
    void Start()
    {
        boardFood = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        foodSprite();
    }

    void foodSprite()
    {
        if (CuttingBoard.currentCooking.Equals(FoodStack.cutFood[0]))
        {
            boardFood.sprite = cutfood.cutFoodStack[0];
        }
        if (CuttingBoard.currentCooking.Equals(FoodStack.cutFood[1]))
        {
            boardFood.sprite = cutfood.cutFoodStack[1];
        }
        if (CuttingBoard.currentCooking.Equals(" "))
        {
            boardFood.sprite = null;
        }
    }
}
