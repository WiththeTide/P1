using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FoodSystem;
using player;
using TMPro;

namespace tableScript
{
    public class Table : MonoBehaviour
    {
        // Update is called once per frame
        public bool playerOn;
        public static Stack<string> tableCapacity = new Stack<string>();
        public TMP_Text info;
        public TMP_Text currentFood;
        private void Start()
        {
            playerOn = false;
        }

        void Update()
        {
            storeFood();
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Debug.Log("enterTable");
            playerOn = true;
            FoodStack.allControl = true;
            if (tableCapacity.Count >= 1)
            {
                if (FoodStack.allControl)
                {
                    currentFood.text = tableCapacity.Peek();
                }
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            //Debug.Log("ExitTable");
            playerOn = false;
            FoodStack.allControl = false;
            if (!FoodStack.allControl)
            {
                currentFood.text = string.Empty;
            }
        }
        private void OnMouseEnter()
        {
            info.text = "The Brown Planet";
        }

        private void OnMouseExit()
        {
            info.text = string.Empty;
        }
        private void storeFood()
        {
            if (playerOn == true && Input.GetKeyDown(KeyCode.Space))
            {
                if (!Player.pocket.Equals(" "))
                {
                    if (tableCapacity.Count < 2)
                    {
                        tableCapacity.Push(Player.pocket);
                        Food.emptyPocket();
                    }
                    else
                    {
                        Debug.Log("Table Full");
                    }
                }
                else if (Player.pocket.Equals(" "))
                {
                    if (tableCapacity.Count == 0) { Debug.Log("TableEmpty"); return; }
                    Player.pocket = tableCapacity.Pop();
                }
            }
        }

    }
}
