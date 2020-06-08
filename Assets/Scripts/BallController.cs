using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ball;
    public float ballSpeed;
    public GameObject ballObject;

    public bool ballInPlay;

    public Transform ballRespawnLocation;

    public UIManager UIMan;
    public GameObject brokenBrick;

    public SoundController sounds;
    

    // Start is called before the first frame update
    void Start()
    {
        ball.isKinematic = true;

        ballInPlay = false;

      
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && ballInPlay == false)
        {
            transform.parent = null;

            ball.isKinematic = false;
            
            ball.AddForce(new Vector2(ballSpeed, ballSpeed));

            ballInPlay = true;
        }

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            sounds.PlaySound("brickBreak");

            UIMan.AddScore();
        }


        if (collision.collider.CompareTag("Brick2"))
        {
            Destroy(collision.gameObject);
            sounds.PlaySound("brickBreak");

            GameObject newBrick = Instantiate(brokenBrick, collision.gameObject.transform.position, Quaternion.identity);
            newBrick.tag = "Brick";
            UIMan.AddScore();
        }
        

        if (collision.collider.CompareTag("ColumnD"))
        {
            UIMan.LoseLife();
            sounds.PlaySound("loseLife");

            if(UIMan.GetLife() < 0)
            {
                UIMan.LoseScreen();
            }
            ballInPlay = false;
            ball.isKinematic = true;
            GameObject newBall = Instantiate(ballObject, ballRespawnLocation.transform.position, Quaternion.identity) as GameObject;
            newBall.transform.parent = GameObject.Find("Platform").transform;
            
            Destroy(ballObject);
           
        }
        if (collision.collider.CompareTag("Platform"))
        {
            
            sounds.PlaySound("platformHit");

            
        }
    }

    
}
