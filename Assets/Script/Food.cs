using Mono.Cecil;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using player;

namespace FoodSystem
{

    public class Food : MonoBehaviour
    {
        public static Action emptyPocket;
        private bool playerEnterTheFridge;
        private bool playerEnterTheTable;
        private bool playerEnterTheGrill;
        private bool playerEnterTheBoard;
        private bool playerEnterThePan;
        private string PlayerPocket;
        
        [SerializeField]
        private FoodStack _stack;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        [SerializeField]
        private GameObject _gameObject;

        void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
   
        }

        void Update()
        {
            playerEnterTheFridge = GameObject.Find("fridge").GetComponent<Fridge>().playerOn;
            playerEnterTheTable = GameObject.Find("Table").GetComponent<Table>().playerOn;
            playerEnterTheGrill = GameObject.Find("Grill").GetComponent<Grill>().playerOn;
            playerEnterTheBoard = GameObject.Find("Cutting Board").GetComponent<CuttingBoard>().playerOn;
            playerEnterThePan = GameObject.Find("Pan").GetComponent<Pan>().playerOn;
            emptyPocket = SetupFoodSpriteToNull;
            PlayerPocket = Player.pocket;
            SetupFoodSpriteWithItsName();

        }
        private void SetupFoodSpriteWithItsName()
        {
            if (playerEnterTheFridge || playerEnterTheTable || playerEnterTheGrill || playerEnterTheBoard || playerEnterThePan)
            {
                //Debug.Log("EnterTheTableS");
                if (PlayerPocket.Equals(FoodStack.foodName[0]))
                {
                    _spriteRenderer.sprite = _stack.foodStack[0];
                }
                else if (PlayerPocket.Equals(FoodStack.foodName[1]))
                {
                    _spriteRenderer.sprite = _stack.foodStack[1];
                }
                else if (PlayerPocket.Equals(FoodStack.foodName[2]))
                {
                    _spriteRenderer.sprite = _stack.foodStack[2];
                }
                else if (PlayerPocket.Equals(FoodStack.foodName[3]))
                {
                    _spriteRenderer.sprite = _stack.foodStack[3];
                }
                else if (PlayerPocket.Equals(FoodStack.foodName[4]))
                {
                    _spriteRenderer.sprite = _stack.foodStack[4];
                }
                else if (PlayerPocket.Equals(FoodStack.foodName[5]))
                {
                    _spriteRenderer.sprite = _stack.foodStack[5];
                }
                else if (PlayerPocket.Equals(FoodStack.grilledFood[0]))
                {
                    _spriteRenderer.sprite = _stack.grilledFoodStack[0];
                }
                else if (PlayerPocket.Equals(FoodStack.grilledFood[1]))
                {
                    _spriteRenderer.sprite = _stack.grilledFoodStack[1];
                }
                else if (PlayerPocket.Equals(FoodStack.panFood[0]))
                {
                    _spriteRenderer.sprite = _stack.panFoodStack[0];
                }
                else if (PlayerPocket.Equals(FoodStack.panFood[1]))
                {
                    _spriteRenderer.sprite = _stack.panFoodStack[1];
                }
                else if (PlayerPocket.Equals(FoodStack.cutFood[0]))
                {
                    _spriteRenderer.sprite = _stack.cutFoodStack[0];
                }
                else if (PlayerPocket.Equals(FoodStack.cutFood[1]))
                {
                    _spriteRenderer.sprite = _stack.cutFoodStack[1];
                }
            }
        }
        private void SetupFoodSpriteToNull()
        {
             Sprite sprite = null;
             _spriteRenderer.sprite = sprite;
             Player.pocket = " ";      
        }
      
    }
}