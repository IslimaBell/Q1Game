using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDaCharacter : MonoBehaviour
{
    public float accel = 10;
    public float speedKap = 3;
    public GameObject mainPlayer;
    public Animator animator;

    private Vector3 playerOrigin;   
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        playerOrigin = mainPlayer.transform.position;
        transform.localPosition = playerOrigin;
        
        

    }
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rb2.velocity);
        if (rb2.velocity.x > speedKap)
        {
            rb2.velocity = new Vector2(speedKap, rb2.velocity.y);
        }

        if (rb2.velocity.x < -speedKap)
        {
            rb2.velocity = new Vector2(-speedKap, rb2.velocity.y);
        }
       
        
        if (Input.GetKeyDown(KeyCode.End))
        {
            transform.position = new Vector3(200, 3, 0);
            rb2.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            transform.position = new Vector3(135, 1, 0);
            rb2.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
    private void FixedUpdate()
    {

        //Move right
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
            animator.SetBool("moving", true);
            rb2.AddForce(new Vector2(accel, 0));
            
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(-accel, 0));
            animator.SetBool("moving", true);

        }
        else
        {
            animator.SetBool("moving", false);
        }



    }
}
