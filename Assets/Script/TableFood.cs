using FoodSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableFood : MonoBehaviour
{
    // Start is called before the first frame update
    public FoodStack tablefood;

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
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            
        }
    }
}
