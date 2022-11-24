using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallLife : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Armagedon"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }    
}
