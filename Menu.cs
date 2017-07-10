using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public string mainGameName;

	public void StartGame()
	{
		SceneManager.LoadScene(mainGameName);
	}


}
