using UnityEngine;
using System.Collections;

public class Landing : MonoBehaviour
{
    public Collider2D Base;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Player")
        {
            StartCoroutine(CheckIfStillThere(collision));
        }
    }
    IEnumerator CheckIfStillThere(Collision2D collision)
    {
        yield return new WaitForSeconds(2);
        if (collision.otherCollider.IsTouching(Base))
        {
            Debug.Log("WIN");
        }
    }
}
