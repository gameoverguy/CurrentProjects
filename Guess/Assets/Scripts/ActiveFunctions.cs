using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ActiveFunctions : MonoBehaviour
{
	public GameObject manager;
	private Parameters parameter;
	private PassiveFunctions passivefunction;
	private Levels Level;
	private AudioManager AM;
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		passivefunction = manager.GetComponent<PassiveFunctions>();
		parameter = manager.GetComponent<Parameters>();
		Level = manager.GetComponent<Levels>();
		AM = manager.GetComponent<AudioManager>();
	}
	
	public void Play()
	{
		AM.PlayGenericButtonClick();
		parameter.MainMenu.SetActive(false);
		parameter.GuessTheLogoCategory.SetActive(true);
	}
	
	public void Settings()
	{
		AM.PlayGenericButtonClick();
		parameter.MainMenu.SetActive(false);
		parameter.Settings.SetActive(true);
	}
	
	public void Quit()
	{
		AM.PlayGenericButtonClick();
		Application.Quit();
	}
	
	public void ResetGame()
	{
		parameter.ResetGameDialog.SetActive(true);
	}
	
	public void ResetGameNo()
	{
		parameter.ResetGameDialog.SetActive(false);
	}
	
	public void ResetGameYes()
	{
		AM.PlayGenericButtonClick();
		parameter.CurrentScore = 0;
		parameter.CurrentGold = 150;
		
		//Reset UnLocked level with bool
		for (int i = 1; i < 7; i++)
		{
			parameter.ActorsPackBool[i] = true;
			parameter.AppsPackBool[i] = true;
			parameter.CartoonsPackBool[i] = true;
			parameter.FamousPackBool[i] = true;
			parameter.FlagsPackBool[i] = true;
			parameter.LandmarksPackBool[i] = true;
			parameter.SoftwaresPackBool[i] = true;
			parameter.SuperheroesPackBool[i] = true;
			parameter.VehiclesPackBool[i] = true;
			parameter.PackCheckMark[i].SetActive(false);
		}
		
		//Reset Actors Level
		for (int i = 0; i < parameter.ActorsPack.Length; i++)
		{
			for (int j = 0; j < parameter.ActorsPack[i].Question.Length; j++)
			{
				parameter.ActorsPack[i].Question[j].Answered = false;
			}
			parameter.ActorsPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.ActorsPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.ActorsPackButtonText[i] = "Play";
			parameter.ActorsPackCheckBool[i] = false;
		}
		
		//Reset Apps Level
		for (int i = 0; i < parameter.AppsPack.Length; i++)
		{
			for (int j = 0; j < parameter.AppsPack[i].Question.Length; j++)
			{
				parameter.AppsPack[i].Question[j].Answered = false;
			}
			parameter.AppsPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.AppsPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.AppsPackButtonText[i] = "Play";
			parameter.AppsPackCheckBool[i] = false;
		}
		
		//Reset Cartoon Level
		for (int i = 0; i < parameter.CartoonsPack.Length; i++)
		{
			for (int j = 0; j < parameter.CartoonsPack[i].Question.Length; j++)
			{
				parameter.CartoonsPack[i].Question[j].Answered = false;
			}
			parameter.CartoonsPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.CartoonsPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.CartoonsPackButtonText[i] = "Play";
			parameter.CartoonsPackCheckBool[i] = false;
		}
		
		//Reset Famous Level
		for (int i = 0; i < parameter.FamousPack.Length; i++)
		{
			for (int j = 0; j < parameter.FamousPack[i].Question.Length; j++)
			{
				parameter.FamousPack[i].Question[j].Answered = false;
			}
			parameter.FamousPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.FamousPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.FamousPackButtonText[i] = "Play";
			parameter.FamousPackCheckBool[i] = false;
		}
		
		//Reset Flags Level
		for (int i = 0; i < parameter.FlagsPack.Length; i++)
		{
			for (int j = 0; j < parameter.FlagsPack[i].Question.Length; j++)
			{
				parameter.FlagsPack[i].Question[j].Answered = false;
			}
			parameter.FlagsPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.FlagsPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.FlagsPackButtonText[i] = "Play";
			parameter.FlagsPackCheckBool[i] = false;
		}
		
		//Reset Famous Level
		for (int i = 0; i < parameter.LandmarksPack.Length; i++)
		{
			for (int j = 0; j < parameter.LandmarksPack[i].Question.Length; j++)
			{
				parameter.LandmarksPack[i].Question[j].Answered = false;
			}
			parameter.LandmarksPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.LandmarksPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.LandmarksPackButtonText[i] = "Play";
			parameter.LandmarksPackCheckBool[i] = false;
		}
		
		//Reset Software Level
		for (int i = 0; i < parameter.SoftwaresPack.Length; i++)
		{
			for (int j = 0; j < parameter.SoftwaresPack[i].Question.Length; j++)
			{
				parameter.SoftwaresPack[i].Question[j].Answered = false;
			}
			parameter.SoftwaresPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.SoftwaresPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.SoftwaresPackButtonText[i] = "Play";
			parameter.SoftwaresPackCheckBool[i] = false;
		}
		
		//Reset Superheroes Level
		for (int i = 0; i < parameter.SuperheroesPack.Length; i++)
		{
			for (int j = 0; j < parameter.SuperheroesPack[i].Question.Length; j++)
			{
				parameter.SuperheroesPack[i].Question[j].Answered = false;
			}
			parameter.SuperheroesPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.SuperheroesPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.SuperheroesPackButtonText[i] = "Play";
			parameter.SuperheroesPackCheckBool[i] = false;
		}
		
		//Reset Vehicles Level
		for (int i = 0; i < parameter.VehiclesPack.Length; i++)
		{
			for (int j = 0; j < parameter.VehiclesPack[i].Question.Length; j++)
			{
				parameter.VehiclesPack[i].Question[j].Answered = false;
			}
			parameter.VehiclesPackCorrectAnswers[i] = 0;
			parameter.Questionslider[i].value = 0;
			parameter.VehiclesPackPanelImage[i] = parameter.BasicGuessData.Orange;
			//parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
			parameter.VehiclesPackButtonText[i] = "Play";
			parameter.VehiclesPackCheckBool[i] = false;
		}
		
		parameter.ResetGameDialog.SetActive(false);
	}
	
	
	
	public void Actors()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 0;
		for (int i = 0; i < parameter.ActorsPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Apps()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 1;
		
		for (int i = 0; i < parameter.AppsPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Cartoons()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 2;
		
		for (int i = 0; i < parameter.CartoonsPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Famous()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 3;
		
		for (int i = 0; i < parameter.FamousPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Flags()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 4;
		
		for (int i = 0; i < parameter.FlagsPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Landmarks()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 5;
		
		for (int i = 0; i < parameter.LandmarksPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Softwares()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 6;
		
		for (int i = 0; i < parameter.SoftwaresPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Superheroes()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 7;
		
		for (int i = 0; i < parameter.SuperheroesPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}
	
	public void Vehicles()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.CategoryNumber = 8;
		
		for (int i = 0; i < parameter.VehiclesPack.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(true);
		}
		parameter.CategoryLevel.SetActive(true);

	}

	
	public void CheckOption01()
	{
		AM.PlayGenericButtonClick();
		parameter.sprState[0] = parameter.ChoicesButton[0].spriteState;
		parameter.sprState[0].disabledSprite = parameter.BasicGuessData.Chosen;
		parameter.ChoicesButton[0].spriteState = parameter.sprState[0];
			
		passivefunction.TurnoffButtons();

		if(parameter.QuestionData.isAnswer[0])
		{
			parameter.CorrectAnswer[0] = true;
		}
		else
		{
			parameter.InCorrectAnswer[0] = true;
		}
		
		
	}
	
	public void CheckOption02()
	{
		AM.PlayGenericButtonClick();
		parameter.sprState[1] = parameter.ChoicesButton[1].spriteState;
		parameter.sprState[1].disabledSprite = parameter.BasicGuessData.Chosen;
		parameter.ChoicesButton[1].spriteState = parameter.sprState[1];
			
		passivefunction.TurnoffButtons();

		if(parameter.QuestionData.isAnswer[1])
		{
			parameter.CorrectAnswer[1] = true;
		}
		else
		{
			parameter.InCorrectAnswer[1] = true;
		}

	}
	
	public void CheckOption03()
	{
		AM.PlayGenericButtonClick();
		parameter.sprState[2] = parameter.ChoicesButton[2].spriteState;
		parameter.sprState[2].disabledSprite = parameter.BasicGuessData.Chosen;
		parameter.ChoicesButton[2].spriteState = parameter.sprState[2];
			
		passivefunction.TurnoffButtons();

		if(parameter.QuestionData.isAnswer[2])
		{
			parameter.CorrectAnswer[2] = true;
		}
		else
		{
			parameter.InCorrectAnswer[2] = true;
		}
		
	}
	
	public void CheckOption04()
	{
		AM.PlayGenericButtonClick();
		parameter.sprState[3] = parameter.ChoicesButton[3].spriteState;
		parameter.sprState[3].disabledSprite = parameter.BasicGuessData.Chosen;
		parameter.ChoicesButton[3].spriteState = parameter.sprState[3];
	
		passivefunction.TurnoffButtons();

		if(parameter.QuestionData.isAnswer[3])
		{
			parameter.CorrectAnswer[3] = true;
		}
		else
		{
			parameter.InCorrectAnswer[3] = true;
		}
		
	}


	
	public void GoToNextLevel()
	{
		AM.PlayGenericButtonClick();
		passivefunction.ResetLevel();
		parameter.CategoryLevel.SetActive(true);
		parameter.LevelCompletedView.SetActive(false);
	}
	
	
	public void ReplayLevel()
	{
		AM.PlayGenericButtonClick();
		parameter.LevelCompletedView.SetActive(false);
		FindObjectOfType<InterstitialAd>().ShowAd();
		parameter.CurrentlevelView.SetActive(true);
		
		if(parameter.CategoryNumber == 0)
			parameter.ActorsPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 1)
			parameter.AppsPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 2)
			parameter.CartoonsPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 3)
			parameter.FamousPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 3)
			parameter.FlagsPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 3)
			parameter.LandmarksPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 3)
			parameter.SoftwaresPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 3)
			parameter.SuperheroesPackQuestion[parameter.Lvl] = 1;
		if(parameter.CategoryNumber == 3)
			parameter.VehiclesPackQuestion[parameter.Lvl] = 1;
		
		passivefunction.ResetLevel();
		passivefunction.TurnOnButtons();
	}
	
	
	public void BacktoMainMenu()
	{
		AM.PlayGenericButtonClick();
		parameter.GuessTheLogoCategory.SetActive(false);
		parameter.Settings.SetActive(false);
		parameter.MainMenu.SetActive(true);
	}
	
	
	public void BacktoCategories()
	{
		AM.PlayGenericButtonClick();
		for (int i = 0; i < parameter.BlankLevels.Length; i++)
		{
			parameter.BlankLevels[i].SetActive(false);
		}
		parameter.GuessTheLogoCategory.SetActive(true);
		parameter.CategoryLevel.SetActive(false);
	}
	
	public void BacktoCategoryLevels()
	{
		AM.PlayGenericButtonClick();
		parameter.CurrentlevelView.SetActive(false);
		parameter.CategoryLevel.SetActive(true);
	}
	
	public void BacktoCategoryLevelsFromLevelCompleted()
	{
		AM.PlayGenericButtonClick();
		parameter.LevelCompletedView.SetActive(false);
		FindObjectOfType<InterstitialAd>().ShowAd();
		parameter.CategoryLevel.SetActive(true);
	}
	
	
	public void RemoveOption()
	{
		AM.PlayGenericButtonClick();
		//parameter.CurrentGold = int.Parse(parameter.CoinsText.text);
		
		if(parameter.CurrentGold >= 50 && parameter.yesclick < 2)
		{
			parameter.RemoveOptionDialog.SetActive(true);
		}
		else if(parameter.CurrentGold < 50)
		{
			parameter.RewardAdsDialog.SetActive(true);
		}
		
	}
	
	public void RemoveYes()
	{
		AM.PlayGenericButtonClick();
		parameter.CurrentGold = int.Parse(parameter.CoinsText.text);
		
		if(parameter.CurrentGold >= 50)
		{
			parameter.CurrentGold = parameter.CurrentGold - 50;
		}
		
		
		parameter.RemoveOptionDialog.SetActive(false);
		
		if(parameter.temp[0] != null)
			parameter.temp[0].SetActive(false);
		
		if(parameter.temp[1] != null)
			parameter.temp[1].SetActive(false);
		
		parameter.IncorrectChoice.RemoveAt(parameter.RandomNumber);
		
		parameter.RandomNumber = Random.Range(0,parameter.IncorrectChoice.Count);
		
		if(parameter.temp[1] == null)
		{
			parameter.temp[1] = parameter.IncorrectChoice[parameter.RandomNumber] as GameObject;
		}
			
		parameter.yesclick++;
		
		if(parameter.yesclick == 2)
		{
			parameter.RemoveOptionButton.SetActive(false);
		}
		
	}
	
	public void RemoveNo()
	{
		AM.PlayGenericButtonClick();
		parameter.RemoveOptionDialog.SetActive(false);
	}
	
	public void WatchAd()
	{
		AM.PlayGenericButtonClick();
		parameter.RewardAdsDialog.SetActive(true);
		

	}
	
	
	public void ShowAnswer()
	{
		AM.PlayGenericButtonClick();
		parameter.CurrentGold = int.Parse(parameter.CoinsText.text);
		
		if(parameter.CurrentGold >= 120)
		{
			parameter.ShowAnswerDialog.SetActive(true);
		}
		else if(parameter.CurrentGold < 120)
		{
			parameter.RewardAdsDialog.SetActive(true);
		}
	}
	
	public void ShowYes()
	{
		AM.PlayGenericButtonClick();
		for (int i = 0; i < 4; i++)
		{
			if(parameter.QuestionData.isAnswer[i])
			{
				parameter.CorrectAnswer[i] = true;
			}
			
			if(!parameter.QuestionData.isAnswer[i])
			{
				parameter.Choices[i].SetActive(false);
			}
		}
		
		passivefunction.TurnoffButtons();
		
		parameter.CurrentGold = int.Parse(parameter.CoinsText.text);
		
		if(parameter.CurrentGold >= 120)
		{
			parameter.CurrentGold = parameter.CurrentGold - 120;
		}
		
		
		parameter.ShowAnswerDialog.SetActive(false);
	}
	
	
	
	public void ShowNo()
	{
		AM.PlayGenericButtonClick();
		parameter.ShowAnswerDialog.SetActive(false);
	}
	
	public void RewardAdsNo()
	{
		AM.PlayGenericButtonClick();
		parameter.RewardAdsDialog.SetActive(false);
	}
	
	
}
