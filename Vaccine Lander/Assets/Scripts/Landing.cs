using UnityEngine;
using System.Collections;

public class Landing : MonoBehaviour
{
    public Collider2D Base;
    public bool fl = false;
    public GameManager manager;
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
            StartCoroutine(manager.Landed());
            //StartCoroutine(manager.GameOverWin());
            //Debug.Log("WIN");
        }
    }
}
