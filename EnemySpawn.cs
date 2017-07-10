using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {


	public GameObject[] ship;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
	int index;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
		{
			index = Random.Range(0,ship.Length);
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-2.4f,2.4f);
			whereToSpawn = new Vector2 (randX, transform.position.y);
			Instantiate (ship[index], whereToSpawn, Quaternion.identity);
		}
	}
}
