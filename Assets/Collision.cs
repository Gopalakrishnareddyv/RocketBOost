using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {  
        if (collision.gameObject.CompareTag("Corner"))
        {
            SceneManager.LoadScene(3);
        }
        else if (collision.gameObject.CompareTag("End"))
        {
            //print("Level-1 completed");
            SceneManager.LoadScene(2);
        }
        else if (collision.gameObject.CompareTag("Corner1"))
        {
            //print("hit a moving body");
            //print("game end");
            //transform.Translate(Vector3.down);
            SceneManager.LoadScene(3);
        }

    }
}
