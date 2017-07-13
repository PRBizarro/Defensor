using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public GUIText scoreText;
	public GUIText lifeText;
	public int score;
	public int life;

	// Use this for initialization
	void Start ()
	 {	
		life = 3;
		UpdateLife();
		score = 0;	
		UpdateScore();
	 }
	
	// Update is called once per frame
	void Update () 
	{
		if (life <= 0)
		{
		
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
