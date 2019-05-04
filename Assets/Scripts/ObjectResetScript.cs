using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectResetScript : MonoBehaviour
{
    public GameObject Player;
    private Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "BolTrap")
        {
            gameObject.transform.position = originalPos;
        }
    }
}
