using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_2_2 : MonoBehaviour
{
  

    //Using a loop add up values from list that are even into the variable sum.
    //The value of sum should be 156 at the end of this loop. (2pts)
    void Start(object even)
    {
        List<int> list = new List<int> { 11, 2, 5, 4, 5, 6, 217, 8, 119, 10, 11, 12, 
            133, 14, 15 ,16 ,117 ,18 ,19, 20, 291, 22, 3, 24, 25};
        int sum = 0;

        for (int i = 0; i < sum ; i++)
        {
            sum += list[i];
        }


        print(sum);
    }
}
