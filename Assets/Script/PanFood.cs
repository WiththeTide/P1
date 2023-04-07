using FoodSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanFood : MonoBehaviour
{
    // Start is called before the first frame update
    public FoodStack panfood;

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
        if (Pan.currentCooking.Equals(FoodStack.panFood[0]))
        {
            boardFood.sprite = panfood.panFoodStack[0];
        }
        if (Pan.currentCooking.Equals(FoodStack.panFood[1]))
        {
            boardFood.sprite = panfood.panFoodStack[1];
        }
        if (Pan.currentCooking.Equals(" "))
        {
            boardFood.sprite = null;
        }
    }
}
