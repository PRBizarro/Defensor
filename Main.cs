using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject Spawn4;
	public GameObject Spawn3;

	public GameObject Spawn2;
	public GUIText scoreText;
	public GUIText lifeText;
	public GameObject[] bateriaUI;
	public int score;
	public int life;

	private GameOver go;

	// Use this for initialization
	void Start ()
	 {	
		 
		Time.timeScale = 1;
		go = GameObject.FindWithTag("Canvas").GetComponent<GameOver>();
		life = 3;
		UpdateLife();
		score = 0;	
		UpdateScore();
	 }
	
	// Update is called once per frame
	void Update () 
	{
		AddSpawnPoints();
		LifeToBateria();
		CheckAchievments();
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore();
	}

	void UpdateLife()
	{
		lifeText.text = "Life: " + life;
	}

	public void TakeLife (int newLifeValue)
	{
		life -= newLifeValue;
		UpdateLife();
	}

	public void AddSpawnPoints()
	{
		if(score > 1000)
		{
			Spawn4.SetActive(true);
		}

		if(score > 500)
		{
			Spawn3.SetActive(true);
		}

		if(score > 100)
		{
			Spawn2.SetActive(true);
		}
	}

	public void  LifeToBateria()
	{
		if (life == 2)
		{
			bateriaUI[0].SetActive(true);
		}

		if (life == 1)
		{
			bateriaUI[1].SetActive(true);	
		}

		if (life == 0)
		{
			bateriaUI[2].SetActive(true);
		}

		if (life < 0)
		{
			go.GameIsOver();	
		}
	}

	public void CheckAchievments()
	{
		if(score > 100)
		{
			Social.ReportProgress(DefensorResources.achievement_heri_da_rua,100.0f, (bool success) => {});
			print("100 pontos");
		}

		if(score > 250)
		{
			Social.ReportProgress(DefensorResources.achievement_heri_do_bairro,100.0f, (bool success) => {});
			print("250 pontos");
		}

		if(score > 500)
		{
			Social.ReportProgress(DefensorResources.achievement_heri_da_cidade,100.0f, (bool success) => {});
			print("500 pontos");
		}

		if(score > 1000)
		{
			Social.ReportProgress(DefensorResources.achievement_heri_nacional,100.0f, (bool success) => {});
		}

		if(score > 2000)
		{
			Social.ReportProgress(DefensorResources.achievement_heri_do_planeta_terra,100.0f, (bool success) => {});
		}

		if(score > 3000)
		{
			Social.ReportProgress(DefensorResources.achievement_o_heri_ruma_ao_infinito,100.0f, (bool success) => {});
		}
}
}
