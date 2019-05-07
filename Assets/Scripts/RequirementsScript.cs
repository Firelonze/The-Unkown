using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequirementsScript : MonoBehaviour
{
    private float timeLeft;
    public bool Alive;
    // Start is called before the first frame update
    void Start()
    {
        //for loop
        //while loop
    }

    // Update is called once per frame
    void Update()
    {
        while (Alive == true)
        {
            timeLeft += Time.deltaTime;
        }
    }
}
