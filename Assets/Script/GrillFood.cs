using FoodSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillFood : MonoBehaviour
{
    // Start is called before the first frame update
    public FoodStack grillfood;

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
        if (Grill.currentCooking.Equals(FoodStack.grilledFood[0]))
        {
            boardFood.sprite = grillfood.grilledFoodStack[0];
        }
        if (Grill.currentCooking.Equals(FoodStack.grilledFood[1]))
        {
            boardFood.sprite = grillfood.grilledFoodStack[1];
        }
        if (Grill.currentCooking.Equals(" "))
        {
            boardFood.sprite = null;
        }
    }
}
