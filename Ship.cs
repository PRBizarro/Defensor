using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	public float thrust;
	private float velocity = 0f;
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
		IncVel();
	}
	
	// Update is called once per frame
	void Update () {
		ship.AddForce(transform.up * (-thrust - velocity));
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			FindObjectOfType<AudioManager>().Play("NaveExplosao");
			Destroy(col.gameObject);
			Destroy(gameObject);
			Instantiate(explosionNave, gameObject.transform.position, gameObject.transform.rotation);
			main.AddScore (pontosdados);			
		}

		if(col.gameObject.tag == "CityLife")
		{
			FindObjectOfType<AudioManager>().Play("CidadeExplosao");
			Destroy(gameObject);
			main.TakeLife (danotomado);
			Instantiate(explosionChao, gameObject.transform.position, gameObject.transform.rotation);
			if(main.life > 0)
			{
				GameObject.FindWithTag("MainCamera").GetComponent<CameraShake>().Shake();
			}	
		}

		if(col.gameObject.tag == "Direita" || col.gameObject.tag == "Esquerda" || col.gameObject.tag == "Teto")
		{
			Destroy(gameObject);
		}
	}

		//Limpar a cagada que é essa função, implementada só para testes
		public void IncVel()
		{
			if (main.score > 50)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 100)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 150)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 200)
			{
				velocity = velocity + 0.1f;
			}
			if (main.score > 250)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 300)
			{
				velocity = velocity + 0.1f;
			}
			if (main.score > 350)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 400)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 450)
			{
				velocity = velocity + 0.1f;
			}	
			if (main.score > 500)
			{
				velocity = velocity + 0.1f;
			}
		}

}
