﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSecretEmd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Debug.Log("Switch scene");
                SceneManager.LoadScene("SecretEnd");
            }
        }
}
