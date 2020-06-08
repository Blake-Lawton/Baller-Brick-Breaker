using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Transform target;
    public bool isMovingLeft = false;
    public bool isMovingRight = false;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Input.GetAxis("Horizontal");
        /*
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = new Vector2(-speed, 0);
            isMovingLeft = true;

        }
        if (Input.GetKeyDown("d"))
         {
             rb.velocity = new Vector2(speed, 0);
             isMovingRight = true;
         }

        if (Input.GetKeyUp("a"))
        {
            isMovingLeft = false;
        }
        if(Input.GetKeyUp("d"))
        {
            isMovingRight = false;
        }

        if(isMovingLeft == false && isMovingRight == false)
        {
            rb.velocity = Vector2.zero;
        }
        */
        transform.Translate(Vector3.left * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
         Vector3 pos = transform.position;
          pos.x = Mathf.Clamp(pos.x, -4.0f, 3.95f);
         transform.position = pos;


    }

    
}
