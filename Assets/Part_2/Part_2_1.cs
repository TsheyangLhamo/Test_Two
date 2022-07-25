using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_2_1 : MonoBehaviour
{
    //Using a loop copy even numbers that are under value of 30
    //from the array to the list. (2pts)
    //Your list should have these values: 22, 2, 12 
    void Start()
    {
        int[] array = new int[10] { 22, 58, 7, 91, 23, 354, 1, 2, 40, 12 };
        List<int> list = new List<int>();
        for (int i= 0; i< array.Length; i++)
        {
            if (i < 30 && i % 2 == 0)
            {
                list.Add(i);
            }
        }
           
       
    }

}
