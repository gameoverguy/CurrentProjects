using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	void Start()
	{

	}
	
	public void Play()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void Retry()
	{
		//SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
		SceneManager.LoadScene("Gamelevel 01");
	}

	public void Quit()
	{
		Application.Quit();
	}
	
	
	
}

