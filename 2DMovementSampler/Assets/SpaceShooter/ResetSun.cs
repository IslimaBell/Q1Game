using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSun : MonoBehaviour
{
    private Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Listen for a reset (r)
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.position = new Vector3(2, 2, 0);
            rb2.velocity = new Vector2(0, 0);
        }
    }
}
