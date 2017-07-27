using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScores : MonoBehaviour {

	public int score;
	public int bestScore;
	public Main main;
	public GUIText scoreText;
	public GUIText bestscoreText;
	public GameObject newBestScore;

	void Start()
	{
		bestscoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
	}

	void Update()
	{
		score = main.score;
		scoreText.text = score.ToString();
		if(score > PlayerPrefs.GetInt("BestScore", 0))
		{
			PlayerPrefs.SetInt("BestScore", score);
			bestscoreText.text = score.ToString();
			newBestScore.SetActive(true);
			PlayGamesScript.AddScoreToLeaderboard(DefensorResources.leaderboard_lista_dos_maiores_defensores_da_terra, score); // adiciona o maior ao google board
		}
	}

}
