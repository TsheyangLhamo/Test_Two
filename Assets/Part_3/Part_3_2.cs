using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_2 : MonoBehaviour
{
    //Attach this Script to Part_3_Cube
    void Start(int Part_3_Sphere)
    {
        //Using PrintOutNameAndPosition print out the name and position of the Part_3_Cube (1pt)

        //using GameObject.Find get the transform of Part_3_Sphere and use PrintOutNameAndPosition (1pt)

        //Using transform.Find or transform.Get get the Transform of Part_3_Cylinder which is a child of Part_3_Sphere
        //and use PrintOutNameAndPosition (1pt)

        Transform cube = GameObject.Find("Part_3_Cube").GetComponent<Transform>();
        PrintOutNameAndPosition(cube.name, cube.position);
        Transform Sphere = transform.GetChild(Part_3_Sphere).GetComponent<Transform>();
        PrintOutNameAndPosition(Sphere.name, Sphere.position);
        Transform Cylinder = GetComponent<Transform>();
        PrintOutNameAndPosition(Cylinder.name, Cylinder.position);
    }

    
    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
