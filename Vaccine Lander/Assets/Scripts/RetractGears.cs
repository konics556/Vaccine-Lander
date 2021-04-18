using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetractGears : MonoBehaviour
{
    // Start is called before the first frame update
    public PolygonCollider2D bb;
    public SliderJoint2D LeftGear;
    public SliderJoint2D RightGear;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // Debug.Log(Physics2D.Raycast(transform.position, -Vector2.up));
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y - bb.bounds.extents.y), -Vector2.up, 4);
        //Debug.Log(hit.collider.name);
        try
        {
            if (hit.collider.tag == "Surface")
            {
                Debug.Log("we're there");
                LeftGear.useMotor = true;
                RightGear.useMotor = true;
            }
        }
        catch
        {
            LeftGear.useMotor = false;
            RightGear.useMotor = false;
        }
    }
}
