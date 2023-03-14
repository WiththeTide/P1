using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FoodSystem
{
    public class FoodStack : MonoBehaviour
    {
        public static string[] foodName = { "Potato", "Steak", "Egg", "Chicken Breast", "Cucumber", "Lettuce" };
        public static string[] grilledFood = { "Grilled Potato", "Grilled Steak" };
        public static string[] panFood = { "Fried Egg", "Cooked Chicken Breast" };
        public static string[] cutFood = { "Cucumber Slices", "Salad" };
        public static string[] combo = { "Steak Combo", "Chicken Combo", "Potato Combo" };
        public static bool allControl = false;
        public Sprite[] foodStack;
        public Sprite[] grilledFoodStack;
        public Sprite[] panFoodStack;
        public Sprite[] cutFoodStack;
        public Sprite[] Combo;
    }
}