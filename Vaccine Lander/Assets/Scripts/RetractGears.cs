using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetractGears : MonoBehaviour
{
    // Start is called before the first frame update
    public PolygonCollider2D bb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // Debug.Log(Physics2D.Raycast(transform.position, -Vector2.up));
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y - bb.bounds.extents.y), -Vector2.up, 10);
        Debug.Log(hit.collider.name);
        //if (hit.collider.name == "landingPad")
        //{
        //    Debug.Log("we're there");
        //}
    }
}
