using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VideoManager : MonoBehaviour
{
	//[SerializeField] private Sprite countdownCircleTimer;
	[SerializeField] private TextMeshProUGUI countdownText;
	[SerializeField] private float startTime = 9.0f;
	private float currentTime;
	private float waitTime;
	private bool updateTime;
	[SerializeField] private GameObject AnswerGrid;
	[SerializeField] private GameObject[] GuessQuestions;
	private bool GuessTimeout;
	private bool AnswerTimeout;
	
	private void Start()
	{ 
		currentTime = startTime;
		waitTime = 3.0f;   
		countdownText.text = (int)currentTime+ "";
		updateTime = true;
	}
	private void Update()
	{
		
		
		
		if(updateTime)
		{
			currentTime -= Time.deltaTime;
			
			if (currentTime <= 0.0f)
			{            
				currentTime = 0.0f;
				ShowAnswer();
				AnswerTimeout = true;
				updateTime = false;
			
			}
			
			countdownText.text = (int)currentTime + "";
			float normalizedValue = Mathf.Clamp(currentTime /startTime, 0.0f, 1.0f);
		}
		
		
		if(AnswerTimeout)
		{
			waitTime -= Time.deltaTime;
		
			if(waitTime <= 0.0f)
			{
				waitTime = 0.0f;
				GuessQuestions[0].SetActive(false);
				GuessQuestions[1].SetActive(true);
				currentTime = 9.0f;
				Debug.Log("ok");
				updateTime = true;
			}
			countdownText.text = (int)currentTime + "";
		}
		
		
		
		
		
		/*if (updateTime)
		{
			currentTime -= Time.deltaTime;
			if (currentTime <= 0.0f)
			{
				// Stop the countdown timer              
				updateTime = false;
				currentTime = 0.0f;
				GuessTimeout = true;
			}
			
			countdownText.text = (int)currentTime + "";
			float normalizedValue = Mathf.Clamp(currentTime /startTime, 0.0f, 1.0f);
			
			
		}
		
		waiTime -= Time.deltaTime;
			
		if (waiTime <= 0.0f)
		{
			// Stop the countdown timer              
			waiTime = 0.0f;
			AnswerTimeout = true;
		}
		
		if(GuessTimeout)
		{
			ShowAnswer();
		}
		
		if(AnswerTimeout)
		{
			GuessQuestions[0].SetActive(false);
			GuessQuestions[1].SetActive(true);
			AnswerTimeout = false;
		}*/
		
		
	}
	
	private void ShowAnswer()
	{
		AnswerGrid.SetActive(true);
	}
}
