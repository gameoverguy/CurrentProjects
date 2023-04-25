using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PassiveFunctions : MonoBehaviour
{
	public GameObject manager;
	private Parameters parameter;
	private AudioManager AM;
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		parameter = manager.GetComponent<Parameters>();
		AM = manager.GetComponent<AudioManager>();
	}


	//Initaial Values of All the Level Buttons
	public void InitialValues()
	{
		parameter.waittime = 1f;
		parameter.TransitionTime = 5f;
		
		if(parameter.CurrentScore == 0)
		{
			parameter.CurrentGold = 150;
		}
		
		
		parameter.QuestionImage.sprite = parameter.QuestionData.GuessImage;
		
		for (int i = 0; i < parameter.BlankLevels.Length; i++)
		{
			parameter.LevelNumberText[i].text = (i+1).ToString();
		}

		
		for (int i = 0; i < parameter.sprState.Length; i++)
		{
			parameter.ChoicesButtonText[i].text = parameter.QuestionData.OptionText[i];
			parameter.sprState[i] = parameter.ChoicesButton[i].spriteState;
			parameter.sprState[i].selectedSprite = parameter.BasicGuessData.Chosen;
			parameter.sprState[i].disabledSprite = parameter.BasicGuessData.Regular;
			parameter.ChoicesButton[i].spriteState = parameter.sprState[i];
		}
		
		//Max slider value in the levels
		for (int j = 0; j < parameter.category.Length; j++)
		{
			for (int i = 0; i < parameter.category[j].Level.Length; i++)
			{
				parameter.Questionslider[i].maxValue = parameter.category[j].Level[i].Question.Length;

				if(j==0)
					parameter.ActorsPack[i] = parameter.category[j].Level[i];

				if(j==1)
					parameter.AppsPack[i] = parameter.category[j].Level[i];
					
				if(j==2)
					parameter.CartoonsPack[i] = parameter.category[j].Level[i];
					
				if(j==3)
					parameter.FamousPack[i] = parameter.category[j].Level[i];
					
				if(j==4)
					parameter.FlagsPack[i] = parameter.category[j].Level[i];
					
				if(j==5)
					parameter.LandmarksPack[i] = parameter.category[j].Level[i];
					
				if(j==6)
					parameter.SoftwaresPack[i] = parameter.category[j].Level[i];
					
				if(j==7)
					parameter.SuperheroesPack[i] = parameter.category[j].Level[i];
					
				if(j==8)
					parameter.VehiclesPack[i] = parameter.category[j].Level[i];
					
				
			}


		}
		
		
		for (int i = 0; i < parameter.ActorsPack.Length; i++)
		{
			if(parameter.ActorsPackCorrectAnswers[i] == 0)
			{
				parameter.ActorsPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.AppsPack.Length; i++)
		{
			if(parameter.AppsPackCorrectAnswers[i] == 0)
			{
				parameter.AppsPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.CartoonsPack.Length; i++)
		{
			if(parameter.CartoonsPackCorrectAnswers[i] == 0)
			{
				parameter.CartoonsPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.FamousPack.Length; i++)
		{
			if(parameter.FamousPackCorrectAnswers[i] == 0)
			{
				parameter.FamousPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.FlagsPack.Length; i++)
		{
			if(parameter.FlagsPackCorrectAnswers[i] == 0)
			{
				parameter.FlagsPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.LandmarksPack.Length; i++)
		{
			if(parameter.LandmarksPackCorrectAnswers[i] == 0)
			{
				parameter.LandmarksPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.SoftwaresPack.Length; i++)
		{
			if(parameter.SoftwaresPackCorrectAnswers[i] == 0)
			{
				parameter.SoftwaresPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.SuperheroesPack.Length; i++)
		{
			if(parameter.SuperheroesPackCorrectAnswers[i] == 0)
			{
				parameter.SuperheroesPackButtonText[i] = "PLAY";
			}	
		}
		
		for (int i = 0; i < parameter.VehiclesPack.Length; i++)
		{
			if(parameter.VehiclesPackCorrectAnswers[i] == 0)
			{
				parameter.VehiclesPackButtonText[i] = "PLAY";
			}	
		}
		
		
		for (int i = 0; i < 3; i++)
		{
			parameter.LevelButtonText[i].font = parameter.font[0];	
		}
		
	}
	

	
	public void TurnOnButtons()
	{
		for (int i = 0; i < parameter.ChoicesButton.Length; i++)
		{
			parameter.ChoicesButton[i].interactable = true;
		}
		
		parameter.RemoveOptionButton.SetActive(true);
		parameter.ShowAnswerButton.SetActive(true);
	}
	
	public void TurnoffButtons()
	{	
		for (int i = 0; i < parameter.ChoicesButton.Length; i++)
		{
			parameter.ChoicesButton[i].interactable = false;
		}
		
		parameter.RemoveOptionButton.SetActive(false);
		parameter.ShowAnswerButton.SetActive(false);
	}
	
	
	public void ResetQuestionComponent()
	{
		
		for (int i = 0; i < 4; i++)
		{
			parameter.Choices[i].SetActive(true);
		}
		
		parameter.waittime = 1f;
		parameter.TransitionTime = 5f;
		parameter.QuestionImage.sprite = parameter.QuestionData.GuessImage;
		
		for (int i = 0; i < parameter.sprState.Length; i++)
		{
			parameter.CorrectAnswer[i] = false;
			parameter.InCorrectAnswer[i] = false;
			parameter.ChoicesButtonText[i].text = parameter.QuestionData.OptionText[i];
			
			parameter.sprState[i] = parameter.ChoicesButton[i].spriteState;
			parameter.sprState[i].selectedSprite = parameter.BasicGuessData.Chosen;
			parameter.sprState[i].disabledSprite = parameter.BasicGuessData.Regular;
			parameter.ChoicesButton[i].spriteState = parameter.sprState[i];
		}
		RecordIncorrectOptions();
	}

	

	
	public void LevelCompleted()
	{
		int tmpLvl = parameter.Lvl + 1;
		parameter.CurrentlevelView.SetActive(false);
		parameter.LevelCompletedView.SetActive(true);
		parameter.LevelCompletedText.text = "Level 0" + tmpLvl + " Completed";
		
		//Making these false stops the correct/incorrect sound
		for (int i = 0; i < parameter.Choices.Length; i++)
		{
			parameter.CorrectAnswer[i] = false;
			parameter.InCorrectAnswer[i] = false;
		}
		//-----------------------------------------------------
		
		GameObject Check = parameter.CategoryLevelImageObject[parameter.Lvl].transform.GetChild(3).gameObject;
		
		//Retry Actors Level
		if(parameter.ActorsPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==0)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.ActorsPackBool[parameter.Lvl + 1] = false;
				if(parameter.ActorsPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.ActorsPackCheckBool[parameter.Lvl] = true;
					parameter.ActorsPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.ActorsPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry Apps Level
		if(parameter.AppsPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==1)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.AppsPackBool[parameter.Lvl + 1] = false;
				if(parameter.AppsPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.AppsPackCheckBool[parameter.Lvl] = true;
					parameter.AppsPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.AppsPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
			
			
		}
		
		//Retry Cartoons Level
		if(parameter.CartoonsPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==2)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.CartoonsPackBool[parameter.Lvl + 1] = false;
				if(parameter.CartoonsPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.CartoonsPackCheckBool[parameter.Lvl] = true;
					parameter.CartoonsPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.CartoonsPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry famous Level
		if(parameter.FamousPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==3)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.FamousPackBool[parameter.Lvl + 1] = false;
				if(parameter.FamousPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.FamousPackCheckBool[parameter.Lvl] = true;
					parameter.FamousPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.FamousPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry Flags Level
		if(parameter.FlagsPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==4)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.FlagsPackBool[parameter.Lvl + 1] = false;
				if(parameter.FlagsPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.FlagsPackCheckBool[parameter.Lvl] = true;
					parameter.FlagsPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.FlagsPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry Landmarks Level
		if(parameter.LandmarksPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==5)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.LandmarksPackBool[parameter.Lvl + 1] = false;
				if(parameter.LandmarksPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.LandmarksPackCheckBool[parameter.Lvl] = true;
					parameter.LandmarksPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.LandmarksPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry Softwares Level
		if(parameter.SoftwaresPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==6)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.SoftwaresPackBool[parameter.Lvl + 1] = false;
				if(parameter.SoftwaresPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.SoftwaresPackCheckBool[parameter.Lvl] = true;
					parameter.SoftwaresPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.SoftwaresPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry Superheroes Level
		if(parameter.SuperheroesPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==7)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.SuperheroesPackBool[parameter.Lvl + 1] = false;
				if(parameter.SuperheroesPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.SuperheroesPackCheckBool[parameter.Lvl] = true;
					parameter.SuperheroesPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.SuperheroesPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		//Retry Vehicles Level
		if(parameter.VehiclesPackCorrectAnswers[parameter.Lvl] >= 10)
		{
			if(parameter.CategoryNumber==8)
			{
				parameter.CurrentGold = parameter.CurrentGold + 20;
				parameter.VehiclesPackBool[parameter.Lvl + 1] = false;
				if(parameter.VehiclesPackCorrectAnswers[parameter.Lvl] == 15)
				{
					parameter.VehiclesPackCheckBool[parameter.Lvl] = true;
					parameter.VehiclesPackButtonText[parameter.Lvl] = "Retry";
				}
				parameter.VehiclesPackPanelImage[parameter.Lvl] = parameter.BasicGuessData.Correct;
			}
		}
		
		

	}
	
	
	

	
	public void RecordIncorrectOptions()
	{
		parameter.temp[0] = null;
		parameter.temp[1] = null;
		
		parameter.RemoveOptionButton.SetActive(true);
		
		parameter.IncorrectChoice = new ArrayList();
		
		if(!parameter.QuestionData.isAnswer[0])
		{
			parameter.IncorrectChoice.Add(parameter.Choices[0]);
		}
		
		if(!parameter.QuestionData.isAnswer[1])
		{
			parameter.IncorrectChoice.Add(parameter.Choices[1]);
		}
		
		if(!parameter.QuestionData.isAnswer[2])
		{
			parameter.IncorrectChoice.Add(parameter.Choices[2]);
		}
		
		if(!parameter.QuestionData.isAnswer[3])
		{
			parameter.IncorrectChoice.Add(parameter.Choices[3]);
		}
		

		parameter.RandomNumber = Random.Range(0,parameter.IncorrectChoice.Count);
		
		parameter.temp[0] = parameter.IncorrectChoice[parameter.RandomNumber] as GameObject;
		
		parameter.yesclick = 0;
	}
	
	public void ShowAnswer()
	{
		parameter.CurrentGold = int.Parse(parameter.CoinsText.text);
		
		if(parameter.CurrentGold >= 120)
		{
			parameter.ShowAnswerDialog.SetActive(true);
		}
	}
	
	
	
	public void ShowNo()
	{
		parameter.ShowAnswerDialog.SetActive(false);
	}
	
	public void GuessLogoScore()
	{
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 0)
		{
			parameter.CurrentScore++;
			parameter.ActorsPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
			
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 1)
		{
			parameter.CurrentScore++;
			parameter.AppsPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}

		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 2)
		{
			parameter.CurrentScore++;
			parameter.CartoonsPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
			
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 3)
		{
			parameter.CurrentScore++;
			parameter.FamousPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 4)
		{
			parameter.CurrentScore++;
			parameter.FlagsPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 5)
		{
			parameter.CurrentScore++;
			parameter.LandmarksPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 6)
		{
			parameter.CurrentScore++;
			parameter.SoftwaresPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 7)
		{
			parameter.CurrentScore++;
			parameter.SuperheroesPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}
		
		if(!parameter.QuestionData.Answered & parameter.CategoryNumber == 8)
		{
			parameter.CurrentScore++;
			parameter.VehiclesPackCorrectAnswers[parameter.Lvl]++;
			parameter.QuestionData.Answered = true;
		
		}
		

	}
	
	
	public void SetMaxScore()
	{
		for (int i = 0; i < parameter.category.Length; i++)
		{
			parameter.MaxScore = parameter.MaxScore + (15 * parameter.category[i].Level.Length);
		}
		
		parameter.MaxScoreBool = true;
	}
	
	public void ResetLevel()
	{
		TurnOnButtons();
		
		if(parameter.CategoryNumber == 0)
		{
			parameter.QuestionData = parameter.ActorsPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 1)
		{
			parameter.QuestionData = parameter.AppsPack[parameter.Lvl].Question[0];
		}

		if(parameter.CategoryNumber == 2)
		{
			parameter.QuestionData = parameter.CartoonsPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 3)
		{
			parameter.QuestionData = parameter.FamousPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 4)
		{
			parameter.QuestionData = parameter.FlagsPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 5)
		{
			parameter.QuestionData = parameter.LandmarksPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 6)
		{
			parameter.QuestionData = parameter.SoftwaresPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 7)
		{
			parameter.QuestionData = parameter.SuperheroesPack[parameter.Lvl].Question[0];
		}
		
		if(parameter.CategoryNumber == 8)
		{
			parameter.QuestionData = parameter.VehiclesPack[parameter.Lvl].Question[0];
		}
		
		for (int i = 0; i < parameter.ActorsPackQuestion.Length; i++)
		{
			parameter.ActorsPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.AppsPackQuestion.Length; i++)
		{
			parameter.AppsPackQuestion[i] = 1;	
		}
		for (int i = 0; i < parameter.CartoonsPackQuestion.Length; i++)
		{
			parameter.CartoonsPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.FamousPackQuestion.Length; i++)
		{
			parameter.FamousPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.FlagsPackQuestion.Length; i++)
		{
			parameter.FlagsPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.LandmarksPackQuestion.Length; i++)
		{
			parameter.LandmarksPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.SoftwaresPackQuestion.Length; i++)
		{
			parameter.SoftwaresPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.SuperheroesPackQuestion.Length; i++)
		{
			parameter.SuperheroesPackQuestion[i] = 1;	
		}
		
		for (int i = 0; i < parameter.VehiclesPackQuestion.Length; i++)
		{
			parameter.VehiclesPackQuestion[i] = 1;	
		}
		
		
		
		
		ResetQuestionComponent();
	}
	
	public void StartLevelCommon()
	{
		AM.PlayGenericButtonClick();
		ResetLevel();
		parameter.CategoryLevel.SetActive(false);
		parameter.CurrentlevelView.SetActive(true);
		
		if(parameter.CategoryNumber==0 && parameter.ActorsPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.ActorsPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==1 && parameter.AppsPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.AppsPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==2 && parameter.CartoonsPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.CartoonsPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==3 && parameter.FamousPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.FamousPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==4 && parameter.FlagsPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.FlagsPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==5 && parameter.LandmarksPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.LandmarksPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==6 && parameter.SoftwaresPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.SoftwaresPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==7 && parameter.SuperheroesPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.SuperheroesPackButtonText[parameter.Lvl] = "Continue";
		}
		if(parameter.CategoryNumber==8 && parameter.VehiclesPackCorrectAnswers[parameter.Lvl] < 15)
		{
			parameter.VehiclesPackButtonText[parameter.Lvl] = "Continue";
		}
		
		
	}
	

	
	
	
	
	
	
	
}
