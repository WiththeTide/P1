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
    public AudioSource bin;
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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("ExitFridge");
        playerOn = false;
    }

    private void OnMouseEnter()
    {
        info.text = "The Red Planet";
    }

    private void OnMouseExit()
    {
        info.text = string.Empty;
    }
    private void binFunction()
    {
        if (playerOn == true && Input.GetKeyDown(KeyCode.Space))
        {
            bin.Play();
            Food.emptyPocket();
        }
    }
}
