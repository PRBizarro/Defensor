using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

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
		if (life == 2)
		{
			bateriaUI[0].SetActive(true);
		}

		if (life == 1)
		{
			bateriaUI[1].SetActive(true);	
		}

		if (life <= 0)
		{
			go.GameIsOver();	
		}
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
}
