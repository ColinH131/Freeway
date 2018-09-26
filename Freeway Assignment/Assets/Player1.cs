using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
	public Text GameOverText;
	public float Speed;
	public Canvas Canvas;
	public Text CountText;
	public int Count;
	void Start ()
	{
		SceneManager.GetActiveScene();
		Count = 0;
		CountText.text = "Score:" + Count.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.position = new Vector3(transform.position.x,transform.position.y + Speed, transform.position.z);
		}

		if (Input.GetKeyDown((KeyCode.DownArrow)))
		{
			transform.position = new Vector3(transform.position.x,transform.position.y - Speed, transform.position.z);
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.position = new Vector3(transform.position.x - Speed, transform.position.y, transform.position.z);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.position = new Vector3(transform.position.x + Speed, transform.position.y,transform.position.z);
		}
		if( Input.GetKeyDown(KeyCode.R) )
		{
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}

		if (transform.position.y >= 14)
		{
			Count = Count + 1;
			CountText.text = "Score:" + Count.ToString();
			transform.position = new Vector3(6.85f,-3.79f,0);
		}

		if (Count == 5)
		{
			CountText.text = "Player 1 Wins";
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Car"))
		{
		transform.position = new Vector3(transform.position.x, -3.86f, transform.position.z);
		}
	}

}
