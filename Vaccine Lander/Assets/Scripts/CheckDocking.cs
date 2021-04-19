using UnityEngine;
using System.Collections;

public class CheckDocking : MonoBehaviour
{
    public Collider2D DockingRegionCollider;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            StartCoroutine(CheckIfStillThere(collider));
        }
    }

    IEnumerator CheckIfStillThere(Collider2D collider)
    {
        yield return new WaitForSeconds(2);
        if (collider.IsTouching(DockingRegionCollider))
        {
            if (GameObject.Find("landingPad").GetComponent<Landing>().fl) { 
                Debug.Log("Docked");
                StartCoroutine(GameObject.Find("GameManager").GetComponent<GameManager>().GameOverWin());
            }
            
        }
    }
}
