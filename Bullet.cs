using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private Rigidbody2D bullet;
	public float thrust;

	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		bullet.AddForce(transform.up * thrust);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "CityLife" || col.gameObject.tag == "Direita" || col.gameObject.tag == "Esquerda" || col.gameObject.tag == "Teto")
		{
			Destroy(gameObject);
		}
	}
}
