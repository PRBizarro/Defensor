using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public GameObject PauseUI;
	private bool paused = false;

	// Use this for initialization
	void Start () {		
		PauseUI.SetActive(false);
	}
	
	public void PauseGame()
	{			
		PauseUI.SetActive(true);
		Time.timeScale = 0;
	}

	public void ResumeGame()
	{
		PauseUI.SetActive(false);
		Time.timeScale = 1;
	}

}
