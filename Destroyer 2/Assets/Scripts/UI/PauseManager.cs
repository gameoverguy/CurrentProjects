using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
	public GameObject pauseMenu;
	public GameObject pauseButton;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	void Start()
	{
		if(pauseMenu)
			pauseMenu.SetActive(false);
	}
	
	
	public void QuitToMainMenu()
	{
		SceneManager.LoadScene(0);
		Time.timeScale = 1;
	}
	
	public void Pause()
	{
		Time.timeScale = 0;
		pauseMenu.SetActive(true);
		pauseButton.SetActive(false);
		
	}
	
	public void Resume()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1;
		pauseButton.SetActive(true);
	}
	
	
}

