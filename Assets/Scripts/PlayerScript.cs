using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    
    public float speed;
    public float floatHeight;
    public GameObject PlatformTrap;
    public GameObject Cloud;
    private Vector3 originalPos;
    private Vector3 currentPos;
    private Vector3 initialPosition;
    private Rigidbody2D rb;
    private Rigidbody2D rb2d;
    private Rigidbody2D rb2dF;
    private Rigidbody2D Spike;
    private Rigidbody2D BolT;
    private SpriteRenderer mySpriteRenderer;
    void Start()
    {
        Spike = GetComponent<Rigidbody2D>();
        currentPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z); 
        rb = GetComponent<Rigidbody2D>();
        rb2d = PlatformTrap.GetComponent<Rigidbody2D>();
        rb2dF = Cloud.GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        initialPosition = transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
            mySpriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (mySpriteRenderer != null)
            {
                mySpriteRenderer.flipX = true;
            }
        }
       /* if (gameObject.transform.position == originalPos)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }*/
    }
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            float distance = ((Vector3)hit.point - transform.position).magnitude;
            float heightError = floatHeight - distance;
            if (Input.GetKey(KeyCode.Space) && distance <= 1.3||Input.GetKey(KeyCode.UpArrow) && distance <= 1.3||Input.GetKey(KeyCode.W) && distance <= 1.3)
            {
                rb.AddForce(transform.up * 1700);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lowest Barier")
        {
            gameObject.transform.position = originalPos;
        }
        if (collision.gameObject.tag == "CoinT")
        {
            rb2d.mass = 1;
        }
        if (collision.gameObject.name == "CloudF")
        {
            rb2dF.mass = 1;
        }
        if (collision.gameObject.tag == "Spike")
        {
            //spikeAppear();
            gameObject.transform.position = originalPos;
            //spikeDisappear();
        }
        if (collision.gameObject.name == "BolTrap")
        {
            gameObject.transform.position = originalPos;
        }
        if (collision.gameObject.tag == "Spike" || collision.gameObject.name == "BolTrap" || collision.gameObject.tag == "Lowest Barier")
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
    /*private void OnGUI()
    {
        
    }
    void spikeAppear()
    {
        //make the spike appear and dissapear instantly
    }
    void spikeDisappear()
    {

    }*/
}

