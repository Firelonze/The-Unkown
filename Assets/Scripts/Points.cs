using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "Amazing performance";
        strings[1] = "One Death";
        strings[2] = "Two Deaths";

        foreach (string point in strings)
        {
            print(point);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
