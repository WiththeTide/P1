using player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStage : MonoBehaviour
{
	public static bool g = false;	
    public static bool drag = true;
    public TMP_Text consumeTurns;

    public int stage = 1;
    public GameObject player;
    public GameObject Turns;
    public GameObject Image;
    public GameObject Image2;
    public GameObject Score;
    public GameObject WinCondition;

    GameStage t;
    void Start()
    {
        player = GameObject.Find("Player");
        player.SetActive(false);
        Image.SetActive(false);
        Image2.SetActive(false);
        Turns.SetActive(false);
	    Score.SetActive(false);
        WinCondition.SetActive(false);
    }

   
    void Update()
    {
        if(stage == 1 && Input.GetKeyDown(KeyCode.Space) && Drag2D.holdAllCheck == true)
        {

            Image.SetActive(true);
            Image2.SetActive(true);
            Turns.SetActive(true);
            Score.SetActive(true);
            Debug.Log("playerSpawn");
            player.SetActive(true);
            stage = 2;
			g= true;
            drag = false;

		}
        if(stage == 2)
        {

        }

        if (CalculateScore.scoreNum >= 50)
        {
            consumeTurns.text = "Total Consumed Turns: " + Player.turns;
            WinCondition.SetActive(true);
            CalculateScore.scoreNum = 0;
        }

    }
}
