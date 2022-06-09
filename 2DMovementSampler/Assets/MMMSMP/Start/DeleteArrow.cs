using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Destroy(gameObject);
        }
    }
}
