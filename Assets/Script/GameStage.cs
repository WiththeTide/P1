using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStage : MonoBehaviour
{
	public static bool g = false;	
    public static bool drag = true;

    public int stage = 1;
    public GameObject player;
    public GameObject Turns;
    public GameObject Image;
    public GameObject Score;

	GameStage t;
    void Start()
    {
        player = GameObject.Find("Player");
        player.SetActive(false);
        Image.SetActive(false);
        Turns.SetActive(false);
	    Score.SetActive(false);
    }

   
    void Update()
    {
        if(stage == 1 && Input.GetKeyDown(KeyCode.Space))
        {

            Image.SetActive(true);
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
    }
}
