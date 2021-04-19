using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text bottomText;
    public Slider fuelBar;
    public float fuel = 1.0f;

    private void FixedUpdate()
    {
        fuelBar.value = fuel + GameObject.Find("left").GetComponent<Thrust>().lf + GameObject.Find("right").GetComponent<Thrust>().rf;
        if (fuelBar.value == 0f)
        {
            StartCoroutine(GameOverLose());
        }
        if (GameObject.Find("Player").GetComponent<Transform>().position.y < -20 || GameObject.Find("Player").GetComponent<Transform>().position.y > 70 || GameObject.Find("Player").GetComponent<Transform>().position.x > 80 || GameObject.Find("Player").GetComponent<Transform>().position.x < -80)
        {
            StartCoroutine(GameOverLose());
        }

    }
    public IEnumerator GameOverWin(){
        GameObject.Find("left").GetComponent<Thrust>().enabled = false;
        GameObject.Find("right").GetComponent<Thrust>().enabled = false;
        GameObject.Find("left").GetComponent<Thrust>().LeftThrust.enabled = false;
        GameObject.Find("right").GetComponent<Thrust>().RightThrust.enabled = false;
        GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale = 0;
        //GameObject.Find("Thrust Right").GetComponent<Rigidbody2D>().gravityScale = 0;
        //GameObject.Find("Thrust Left").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("Landing gear right").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("Landing gear left").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("right").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("left").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //GameObject.Find("Thrust Right").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //GameObject.Find("Thrust Left").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GameObject.Find("Landing gear right").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GameObject.Find("Landing gear left").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GameObject.Find("right").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GameObject.Find("left").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        bottomText.text="Mission Complete";
        yield return new WaitForSeconds(2.0f);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public IEnumerator GameOverLose(){
        GameObject.Find("left").GetComponent<Thrust>().enabled = false;
        GameObject.Find("right").GetComponent<Thrust>().enabled = false;
        GameObject.Find("left").GetComponent<Thrust>().LeftThrust.enabled = false;
        GameObject.Find("right").GetComponent<Thrust>().RightThrust.enabled = false;
        bottomText.text="Mission Failed";
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public IEnumerator Landed()
    {
        bottomText.text = "Landed Successfully";
        yield return new WaitForSeconds(2.0f);
        bottomText.text = "";
    }
}
