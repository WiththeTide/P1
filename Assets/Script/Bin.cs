using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;
using FoodSystem;
using TMPro;

public class Bin : MonoBehaviour
{
    private bool playerOn;
    public TMP_Text info;
    public TMP_Text infoF;
    // Start is called before the first frame update
    void Start()
    {
        playerOn = false;
    }

    // Update is called once per frame
    void Update()
    {
       binFunction();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("enterTheBin");
        playerOn = true;
        infoF.text = "Bin: ";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("ExitFridge");
        playerOn = false;
        infoF.text = string.Empty;
    }

    private void OnMouseEnter()
    {
        info.text = "This is Bin";
    }

    private void OnMouseExit()
    {
        info.text = string.Empty;
    }
    private void binFunction()
    {
        if (playerOn == true && Input.GetKeyDown(KeyCode.Space))
        {
            Food.emptyPocket();
        }
    }
}
