using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{

    public float Speed;
    public Text ScoreText;
    public int Score;
    void Start ()
    {
        Score = 0;
        ScoreText.text = "Score:" + Score.ToString();
        SceneManager.GetActiveScene();
    }
	
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("w"))
        {
            transform.position = new Vector3(transform.position.x,transform.position.y + Speed, transform.position.z);
        }

        if (Input.GetKeyDown("s"))
        {
            transform.position = new Vector3(transform.position.x,transform.position.y - Speed, transform.position.z);
        }

        if (Input.GetKeyDown("a"))
        {
            transform.position = new Vector3(transform.position.x - Speed, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.position = new Vector3(transform.position.x + Speed, transform.position.y,transform.position.z);
        }

        if (transform.position.y >= 14)
        {
            transform.position = new Vector3(-10.45f,-3.748f,0);
            Score = Score + 1;
            ScoreText.text = "Score:" + Score.ToString();
        }
        if (Score == 5)
        {
            ScoreText.text = "Player 2 Wins";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
