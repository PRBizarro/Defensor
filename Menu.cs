using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject ControlsUI;
	public GameObject MenuUI;
	public GameObject StLgo;
	
	public string mainGameName;

	public void Start()
	{

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
	}

	public void ExitControls()
	{
		MenuUI.SetActive(true);
		ControlsUI.SetActive(false);
	}

	IEnumerator StudioLogo()
	{
		StLgo.SetActive(true);
		yield return new WaitForSeconds(5);
		StLgo.SetActive(false);
	}
}
