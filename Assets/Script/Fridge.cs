using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using FoodSystem;
using player;
using TMPro;
using UnityEditor.VersionControl;

public class Fridge : MonoBehaviour
{
    // Start is called before the first frame update
    //List<GameObject> food = new List<GameObject>();
    public int i;
    public bool playerOn;
    public TMP_Text info;
    public TMP_Text infoF;

    void Start()
    {
        i = 0;
        playerOn = false;
        info.text = string.Empty;
        
    }

    // Update is called once per frame
    void Update()
    {
        getFood();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("enterThefridge");
        playerOn = true;
        infoF.text = "Fridge: ";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("ExitFridge");
        playerOn = false;
        infoF.text = string.Empty;
    }

    private void OnMouseEnter()
    {
        info.text = "This is Fridge";
    }

    private void OnMouseExit() 
    {
        info.text = string.Empty;
    }

    private void getFood()
    {
        if (playerOn == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (Player.pocket.Equals(" "))
            {
                Player.pocket = FoodStack.foodName[i];
            }
            else if (!Player.pocket.Equals(" "))
            {
                i++;
                if (i > FoodStack.foodName.Length - 1)
                {
                    i = 0;
                }
                Player.pocket = FoodStack.foodName[i];
            }
            Debug.Log(i);
            Debug.Log(Player.pocket);
        }
    }
}
