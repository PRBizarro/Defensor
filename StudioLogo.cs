using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudioLogo : MonoBehaviour {

	float nextSpawn = 2.2f;
	public GameObject mainScreen;
	void Start () {
		mainScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
		{	
			mainScreen.SetActive(true);
			Destroy(gameObject);
		}
	}
}
