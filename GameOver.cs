using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	public GameObject GameoverUI;

	// Use this for initialization
	void Start () {		
		GameoverUI.SetActive(false);
	}
	
	public void GameIsOver()
	{			
		GameoverUI.SetActive(true);
		Time.timeScale = 0;
	}

}
