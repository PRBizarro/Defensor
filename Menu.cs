using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject ControlsUI;
	
	public string mainGameName;

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
	}

	public void ExitControls()
	{
			
		ControlsUI.SetActive(false);
	}


}
