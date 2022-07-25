using UnityEngine;

public class Part_1 : MonoBehaviour
{
    /*
     * You will be presented with five different Arithmetic / Boolean problems, each one is worth 1pt.
     * Underneath each one there is a commented space, type in your answer in there
     */
    void Start()
    {
        //Example ==============================================
        //Question: What is the value of a? 

        int b = 0;

        // Answer: b = 0
        //=====================================================

        //Part 1 (1pt) ==============================================
        //Question: What is the value of x? 

        int x = -1;
        int y = 0;
        int z = 20;

        y = 10 + 5;
        z /= 10;
        x += y + z;

        // Answer: x = -1
        //=====================================================

        //Part 2 (1pt) ==============================================
        //Question: What is the value of isTrue at the end of this? 

        bool isTrue = true;
        x = 144 / 12;
        y = 48 / 4;
        isTrue = x == y;

        // Answer: isTrue = x ==  y
        //=====================================================

        //Part 3 (1pt) ==============================================
        //Question: What is the value of x at the end of this for loop?

        x = 0;
        for (int i = 0; i < 10; i++)
        {
            x += i;
        }

        // Answer: x = i
        //=====================================================

        //Part 4 (1pt) ==============================================
        //Question: What is the value of x after this if statement?

        x = 0;
        string name = "Ash";
        if (name.Length > 5)
        {
            x = 1;
        }
        else if (name == "Ketchum")
        {
            x = 2;
        }
        else if (name.Length < 5)
        {
            x = 3;
        }
        else if (name.Contains("A"))
        {
            x = 4;
        }
        else
        {
            x = 5;
        }

        // Answer: x = 5;
        //=====================================================

        //Part 5 (1pt) ==============================================
        //Question: What is the restult of this for loop? 

        int[] a = new int[3] { 1, 3, 5 };
        for (int i = 0; i < 10; i++)
        {
            a[i] = i;
        }

        // Answer: i = 0; i < 10
        //=====================================================

    }

}
