using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

	public int canonSpeed; 
	public Transform mira;
	public GameObject[] bullets;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * canonSpeed);
	}

	public void FireRed()
	{
		Instantiate (bullets[0], mira.position, mira.rotation);
	}

	public void FireBlue()
	{
		Instantiate (bullets[1], mira.position, mira.rotation);
	}

	public void Firegreen()
	{
		Instantiate (bullets[3], mira.position, mira.rotation);
	}

	public void FireYellow()
	{
		Instantiate (bullets[2], mira.position, mira.rotation);
	}


}
