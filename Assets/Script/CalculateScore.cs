using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;
using FoodSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class CalculateScore : MonoBehaviour
{
    public TMP_Text score;
    public static int scoreNum;
    private bool playerOn;
    public static bool complateCook = false;
    
    // Start is called before the first frame update
    void Awake()
    {
        scoreNum = 0;
   
    }
    private void Update()
    {
        calculate();
        ExitGame();
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
            if (Player.pocket.Equals(Foodgeneration.finaldish2))
            {
                scoreNum += 5;
                Foodgeneration.counter2 = 0;
                score.text = "Score: " + scoreNum.ToString();
                complateCook = true;
                Food.emptyPocket();
            }
            else if (Player.pocket.Equals(Foodgeneration.finaldish))
            {
                scoreNum += 5;
                Foodgeneration.counter1 = 0;
                score.text = "Score: " + scoreNum.ToString();
                complateCook = true;
                Food.emptyPocket();
            }
           
        }
    }
    private void ExitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
