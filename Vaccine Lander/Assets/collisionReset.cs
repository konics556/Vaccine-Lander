using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collisionReset : MonoBehaviour
{
    // Start is called before the first frame update

    public float VeloThreshold;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        Debug.Log(collision.relativeVelocity.magnitude);
        if(collision.relativeVelocity.magnitude > VeloThreshold){
            SceneManager.LoadScene("Level1");
        }
    }
}
