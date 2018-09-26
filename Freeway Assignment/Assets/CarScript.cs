using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {

	public float Speed;
	public SpriteRenderer Spc;
	public float CarCount;
	public Vector3 SpawnPosition;
	public int Timer;
	public GameObject Car;
	private class Cars
	{
		
	}


	private void Start()
	{
		Spc = GetComponent<SpriteRenderer>();
		SpawnPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		CarCount = 4;
		Timer = 3;


	}

	// Update is called once per frame
	private void   Update ()
	{
		
		if (transform.position.x <= -21f)
		{
			gameObject.SetActive(false);
			transform.position = SpawnPosition;
			gameObject.SetActive(true);
			CarCount = CarCount - 1;
			StartCoroutine(Spawn());
		}

		if (transform.position.x >= 23)
		{
			gameObject.SetActive(false);
			transform.position = SpawnPosition;
			gameObject.SetActive(true);
			CarCount = CarCount - 1;
		}
		transform.position = new Vector3(transform.position.x + Speed, transform.position.y, transform.position.z);
	}

	private IEnumerator Spawn()
	{
		yield return new WaitForSeconds(3f);
		SpawnCar();
	}

	public void SpawnCar()
	{
		Instantiate (Car, SpawnPosition,transform.rotation) ;
		CarCount = CarCount + 1;
		
	}

}
