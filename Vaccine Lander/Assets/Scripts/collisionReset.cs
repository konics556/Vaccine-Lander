using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collisionReset : MonoBehaviour
{
    public float VeloThreshold;
    public GameManager manager;
    GameObject Player;
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.relativeVelocity.magnitude > VeloThreshold){
            
            StartCoroutine(manager.GameOverLose());
            //SceneManager.LoadScene("Level1");
        }
    }
}
