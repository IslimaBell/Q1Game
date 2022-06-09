using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    public float rotateScale;
    public float thrustScale;
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject GunPoint;
    public GameObject Bullet2;
    public GameObject GunPoint2;
    public float bulletSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = rotateScale * Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, -rotation));

        float thrust = thrustScale * Input.GetAxis("Vertical");
        rb2.AddForce(transform.up * thrust);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(Bullet, GunPoint.transform.position, Quaternion.identity);
            GameObject b2 = Instantiate(Bullet2, GunPoint2.transform.position, Quaternion.identity);
            Rigidbody2D rb2b = b.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2b2 = b2.GetComponent<Rigidbody2D>();
            rb2b.AddForce(bulletSpeed * transform.up);
            rb2b2.AddForce(bulletSpeed * transform.up);
            Destroy(b, 4);
            Destroy(b2, 4);

        }

        //Listen for a reset (r)
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0, 0, 0);
            rb2.velocity = new Vector2(0, 0);
        }
    }
}
