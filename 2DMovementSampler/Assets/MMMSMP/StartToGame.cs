using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartToGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene("PlatformerLevel1");

        }


    }

    //public void OnMouseDown()
    //{
    //    Debug.Log("Switch scene");
    //    SceneManager.LoadScene("PlatformerLevel1");
    //{
}
