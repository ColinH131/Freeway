using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarScript : MonoBehaviour
{
	private Vector3 StartPosition;
	public float Speed;
	

	// Use this for initialization
	 void  Start () {
		StartPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z);
	
		 
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
