using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Thrust : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ForceValue;
    public bool IsRight;

    void FixedUpdate()
    {
        if (Input.GetAxisRaw("RightThrust") > 0 && IsRight == true)
        {
            rb.AddRelativeForce(new Vector2(0, ForceValue));
        }
        else if (Input.GetAxisRaw("LeftThrust") > 0 && IsRight == false)
        {
            rb.AddRelativeForce(new Vector2(0, ForceValue));
        }
        // rb.AddRelativeForce(new Vector2(HorForce * ForceValue, 0));
    }
}
