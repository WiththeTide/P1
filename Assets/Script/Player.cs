using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using TMPro;

namespace player
{
    public class Player : MonoBehaviour
    {


        private float speed = 3f;
        Vector3 targetPos;
        public static string pocket = " ";
        public static int turns = 0;

        public TMP_Text TurnsCount;
        public TMP_Text PocketMessage;
        // Start is called before the first frame update
        void Start()
        {
            turns = 0;
            //TurnsCount = GameObject.Find("Turns").GetComponent<TMP_Text>();
        }

        // Update is called once per frame
        void Update()
        {
            int currentTurnsNum = turns;
            TurnsCount.text = "Total Turns: " + currentTurnsNum.ToString();
            PocketMessage.text = "Pocket: " + Player.pocket;
            move();

        }

        void move()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log(turns);
                targetPos = new Vector3(transform.position.x, transform.position.y + 3f, -2);
                if (targetPos.y < 4)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
                    turns++;
                }
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log(turns);
                targetPos = new Vector3(transform.position.x - 3f, transform.position.y, -2);
                if (targetPos.x > -4)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
                    turns++;
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log(turns);
                targetPos = new Vector3(transform.position.x, transform.position.y - 3f, -2);
                if (targetPos.y > -4)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
                    turns++;
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log(turns);
                targetPos = new Vector3(transform.position.x + 3f, transform.position.y, -2);
                if (targetPos.x < 4)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
                    turns++;
                }
            }
        }


    }
}