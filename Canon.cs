using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

	public int canonSpeed; 
	public Transform mira;
	public GameObject[] bullets;

	private string direcao;

	// Use this for initialization
	void Start () {
		direcao = "direita";
	}
	
	// Update is called once per frame
	void Update () {
		if(direcao == "esquerda"){
			transform.Rotate(Vector3.forward * Time.deltaTime * canonSpeed);
		}
		if(direcao == "direita"){
			transform.Rotate(Vector3.back * Time.deltaTime * canonSpeed);
		}
	}

	public void FireRed()
	{
		FindObjectOfType<AudioManager>().Play("Shoot");
		Instantiate (bullets[0], mira.position, mira.rotation);
	}

	public void FireBlue()
	{
		FindObjectOfType<AudioManager>().Play("Shoot");
		Instantiate (bullets[1], mira.position, mira.rotation);
	}

	public void Firegreen()
	{
		FindObjectOfType<AudioManager>().Play("Shoot");
		Instantiate (bullets[3], mira.position, mira.rotation);
	}

	public void FireYellow()
	{
		FindObjectOfType<AudioManager>().Play("Shoot");
		Instantiate (bullets[2], mira.position, mira.rotation);
	}

	public void MudarDirecao()
	{
		FindObjectOfType<AudioManager>().Play("InverteCanon");
		if(direcao == "esquerda")
		{
			direcao = "direita";
		}
		else
		{
			direcao = "esquerda";
		}
	}

}
