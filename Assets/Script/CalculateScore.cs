using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;
using FoodSystem;
using TMPro;

public class CalculateScore : MonoBehaviour
{
    public TMP_Text score;
    public int scoreNum;
    private bool playerOn;
    // Start is called before the first frame update
    private void Start()
    {
        scoreNum = 0;
    }
    private void Update()
    {
        calculate();
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

    private void calculate()
    {
        if (playerOn && Input.GetKeyDown(KeyCode.Space))
        {
            if (Player.pocket.Equals(Foodgeneration.dishnumber1.text))
            {
                scoreNum += 5;
                score.text = scoreNum.ToString();
            }
        }
    }
}
