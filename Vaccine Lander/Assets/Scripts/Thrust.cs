using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thrust : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ForceValue;
    public bool IsRight;
    public SpriteRenderer LeftThrust;
    public SpriteRenderer RightThrust;
    public float lf = 0f, rf = 0f;
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("LeftThrust") > 0 && IsRight == false)
        {
            lf -= 0.05f * Time.deltaTime;
            LeftThrust.enabled = true;
            rb.AddRelativeForce(new Vector2(0, ForceValue * Time.deltaTime));
            //return;
        }
        else if(IsRight == false)
        {
            LeftThrust.enabled = false;
        }
        if (Input.GetAxisRaw("RightThrust") > 0 && IsRight == true)
        {
            rf -= 0.05f * Time.deltaTime;
            RightThrust.enabled = true;
            rb.AddRelativeForce(new Vector2(0, ForceValue * Time.deltaTime));
            //return;
        }
        else if(IsRight == true)
        {
            RightThrust.enabled = false;
        }
        // rb.AddRelativeForce(new Vector2(HorForce * ForceValue, 0));
    }
    
}
