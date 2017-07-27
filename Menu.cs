using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using GooglePlayGames;  // Biblioteca de conexao com o google play
//using UnityEngine.SocialPlatforms; // Biblioteca Unity Social Google Play

public class Menu : MonoBehaviour {

	public GameObject ControlsUI;
	public GameObject MenuUI;
	public GameObject StLgo;
	//public bool IsConnectedToGoogleServices = false;
	
	public string mainGameName;

	public void Start()
	{
		//PlayGamesPlatform.Activate(); // Ativando a plataforma do google play
	}


	public void StartGame()
	{
		SceneManager.LoadScene(mainGameName);
	}

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		print("Cena Carregada");
		Time.timeScale = 1;
		print("TimeScale inicializado");
	}

	public void ShowControls()
	{
		ControlsUI.SetActive(true);
		MenuUI.SetActive(false);
		//PlayGamesPlatform.Activate();        // teste
	}

	public void ExitControls()
	{
		MenuUI.SetActive(true);
		ControlsUI.SetActive(false);
	}

	public void ShowAchievements()
	{
		PlayGamesScript.ShowAchievementsUI();
	}

	public void ShowLeaderboards()
	{
		PlayGamesScript.ShowLeaderboardsUI();
	}
	/*public bool ConnectToGoogleServices()
	{
			if(!IsConnectedToGoogleServices)
			{
				Social.localUser.Authenticate((bool success) => { IsConnectedToGoogleServices = success; });
			}
			return IsConnectedToGoogleServices;
	}

	public void ToAchievement()
	{
		if (Social.localUser.authenticated)
		{
			Social.ShowAchievementsUI();
		}
	}

	public void ToLeaderboard()
	{
		if(Social.localUser.authenticated)
		{
			Social.ShowLeaderboardUI ();
		}
	}*/

}
