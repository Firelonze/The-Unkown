using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //foreach() { }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            string[] points = new string[21];
            points[0] = "no points only deaths";
            points[1] = "you wasted your time on one single point";
            points[2] = "Come on it's not that hard to play";
            points[3] = "Really??!";
            points[4] = "Come ON!";
            points[5] = "At least do your best (-_-)";
            points[6] = "At least you tried I guess.....";
            points[7] = "At least you tried I guess....";
            points[8] = "At least you tried I guess...";
            points[9] = "At least you tried I guess..";
            points[10] = "At least you tried I guess.";
            points[11] = "You're getting better";
            points[12] = "Meh you could do better";
            points[13] = "doing better yet?";
            points[14] = "almost half way there";
            points[15] = "You're halfway there sort of";
            points[16] = "You're past half way";
            points[17] = "after this one you would do really great";
            points[18] = "great JK just do better";
            points[19] = "Good job but you could do better";
            points[20] = "You've done well but not perfect";

            foreach (string item in points)
            {
                Debug.Log(points);
            }
        }
    }
}
