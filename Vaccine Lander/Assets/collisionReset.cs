using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collisionReset : MonoBehaviour
{
    public float VeloThreshold;
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.relativeVelocity.magnitude > VeloThreshold){
            SceneManager.LoadScene("Level1");
        }
    }
}
