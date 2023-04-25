using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
	public static bool gameIsPaused;
	[SerializeField] private GameObject Completed;
	
	void Awake()
	{

	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			gameIsPaused = !gameIsPaused;
			PauseGame();
		}
		
		if(Enemies.enemies.Count <= 0)
		{
			GameOverPause();
		}
	}
	void PauseGame()
	{
		if(gameIsPaused)
		{
			Time.timeScale = 0f;
		}
		else 
		{
			Time.timeScale = 1;
		}
	}
	
	void GameOverPause()
	{
		Time.timeScale = 0f;
		Completed.SetActive(true);
	}
	
}

