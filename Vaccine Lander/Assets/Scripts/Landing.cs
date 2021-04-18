using UnityEngine;
using System.Collections;

public class Landing : MonoBehaviour
{
    public Collider2D Base;
    private bool fl = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.collider.tag);
        //Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Player")
        {
            StartCoroutine(CheckIfStillThere(collision));
        }
    }
    IEnumerator CheckIfStillThere(Collision2D collision)
    {
        yield return new WaitForSeconds(2);
        if (collision.collider.IsTouching(Base) && !fl)
        {
            fl = true;
            Debug.Log("WIN");
        }
    }
}
