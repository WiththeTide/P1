using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public float delay = 0.1f;
    float timer;
    public GameObject text;
    public AudioSource start;
    bool on = true;
    // Start is called before the first frame update
    void Start()
    {
        start.Play();
    }

    // Update is called once per frame

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay&&on==true)
        {
            MyFunction();
            timer -= delay;
            on = false;
        }

        if (timer > delay&& on == false)
            {
                MyFunction2();
                timer -= delay;
            on = true;
            }
        if (Input.GetKeyDown("space"))
        {
            start.Stop();
            SceneManager.LoadScene("GameScene");
        }
    }
    void MyFunction()
    {
        Debug.Log("true");
        text.SetActive(false);
    }
    void MyFunction2()
    {
        text.SetActive(true);
    }
}
