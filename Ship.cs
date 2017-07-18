using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	public float thrust;
	private Rigidbody2D ship;
	public GameObject explosionChao;
	public GameObject explosionNave;

	public Main main;
	public int pontosdados;
	public int danotomado;


	// Use this for initialization
	void Start () {
		ship = GetComponent<Rigidbody2D>();
		GameObject MainObject = GameObject.FindWithTag ("MainCamera");
		main = MainObject.GetComponent<Main>();
	}
	
	// Update is called once per frame
	void Update () {
		ship.AddForce(transform.up * -thrust);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
			Instantiate(explosionNave, gameObject.transform.position, gameObject.transform.rotation);
			main.AddScore (pontosdados);
		}

		if(col.gameObject.tag == "CityLife")
		{
			Destroy(gameObject);
			main.TakeLife (danotomado);
			Instantiate(explosionChao, gameObject.transform.position, gameObject.transform.rotation);
		}

		if(col.gameObject.tag == "Direita" || col.gameObject.tag == "Esquerda" || col.gameObject.tag == "Teto")
		{
			Destroy(gameObject);
		}

	}

}
