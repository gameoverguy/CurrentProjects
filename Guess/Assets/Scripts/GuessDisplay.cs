using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class GuessDisplay : MonoBehaviour
{
	public GameObject manager;
	private ActiveFunctions activefunction;
	private PassiveFunctions passivefunction;
	private Parameters parameter;
	private AudioManager AM;
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		parameter = manager.GetComponent<Parameters>();
		activefunction = manager.GetComponent<ActiveFunctions>();
		passivefunction = manager.GetComponent<PassiveFunctions>();
		AM = manager.GetComponent<AudioManager>();
	}

    // Use this for initialization
    void Start ()
	{
		passivefunction.InitialValues();
	}
	
	

	public void Update()
	{
		parameter.CoinsText.text = parameter.CurrentGold.ToString();
		parameter.Scoretext.text = parameter.CurrentScore + " / " + parameter.MaxScore;
		
		
		OptionButtonColorChange();
		
		if(parameter.CategoryNumber == 0)
		{
			for (int i = 0; i < parameter.ActorsPack.Length; i++)
			{
				
				parameter.ProgressText.text = parameter.ActorsPackQuestion[parameter.Lvl] + " / " + parameter.ActorsPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.ActorsPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.ActorsPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.ActorsPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.ActorsPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.ActorsPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.ActorsPackCorrectAnswers[i] + " / " + parameter.ActorsPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.ActorsPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.ActorsPack.Length)
				{

					if(parameter.ActorsPackQuestion[parameter.Lvl] < parameter.ActorsPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.ActorsPack[parameter.Lvl].Question[parameter.ActorsPackQuestion[parameter.Lvl]];
							parameter.ActorsPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						passivefunction.LevelCompleted();
						passivefunction.ResetLevel();
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 1)
		{
			for (int i = 0; i < parameter.AppsPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.AppsPackQuestion[parameter.Lvl] + " / " + parameter.AppsPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.AppsPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.AppsPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.AppsPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.AppsPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.AppsPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.AppsPackCorrectAnswers[i] + " / " + parameter.AppsPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.AppsPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.AppsPack.Length)
				{

					if(parameter.AppsPackQuestion[parameter.Lvl] < parameter.AppsPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.AppsPack[parameter.Lvl].Question[parameter.AppsPackQuestion[parameter.Lvl]];
							parameter.AppsPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						passivefunction.LevelCompleted();
						passivefunction.ResetLevel();
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 2)
		{
			for (int i = 0; i < parameter.CartoonsPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.CartoonsPackQuestion[parameter.Lvl] + " / " + parameter.CartoonsPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.CartoonsPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.CartoonsPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.CartoonsPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.CartoonsPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.CartoonsPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.CartoonsPackCorrectAnswers[i] + " / " + parameter.CartoonsPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.CartoonsPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.CartoonsPack.Length)
				{

					if(parameter.CartoonsPackQuestion[parameter.Lvl] < parameter.CartoonsPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.CartoonsPack[parameter.Lvl].Question[parameter.CartoonsPackQuestion[parameter.Lvl]];
							parameter.CartoonsPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
							
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
							
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 3)
		{
			for (int i = 0; i < parameter.FamousPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.FamousPackQuestion[parameter.Lvl] + " / " + parameter.FamousPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.FamousPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.FamousPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.FamousPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.FamousPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.FamousPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.FamousPackCorrectAnswers[i] + " / " + parameter.FamousPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.FamousPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.FamousPack.Length)
				{

					if(parameter.FamousPackQuestion[parameter.Lvl] < parameter.FamousPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.FamousPack[parameter.Lvl].Question[parameter.FamousPackQuestion[parameter.Lvl]];
							parameter.FamousPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
					}
				}
				
				
			}		
		}
		
		if(parameter.CategoryNumber == 4)
		{
			for (int i = 0; i < parameter.FlagsPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.FlagsPackQuestion[parameter.Lvl] + " / " + parameter.FlagsPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.FlagsPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.FlagsPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.FlagsPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.FlagsPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.FlagsPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.FlagsPackCorrectAnswers[i] + " / " + parameter.FlagsPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.FlagsPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.FlagsPack.Length)
				{

					if(parameter.FlagsPackQuestion[parameter.Lvl] < parameter.FlagsPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.FlagsPack[parameter.Lvl].Question[parameter.FlagsPackQuestion[parameter.Lvl]];
							parameter.FlagsPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 5)
		{
			for (int i = 0; i < parameter.LandmarksPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.LandmarksPackQuestion[parameter.Lvl] + " / " + parameter.LandmarksPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.LandmarksPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.LandmarksPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.LandmarksPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.LandmarksPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.LandmarksPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.LandmarksPackCorrectAnswers[i] + " / " + parameter.LandmarksPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.LandmarksPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.LandmarksPack.Length)
				{

					if(parameter.LandmarksPackQuestion[parameter.Lvl] < parameter.LandmarksPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.LandmarksPack[parameter.Lvl].Question[parameter.LandmarksPackQuestion[parameter.Lvl]];
							parameter.LandmarksPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 6)
		{
			for (int i = 0; i < parameter.SoftwaresPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.SoftwaresPackQuestion[parameter.Lvl] + " / " + parameter.SoftwaresPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.SoftwaresPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.SoftwaresPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.SoftwaresPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.SoftwaresPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.SoftwaresPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.SoftwaresPackCorrectAnswers[i] + " / " + parameter.SoftwaresPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.SoftwaresPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.SoftwaresPack.Length)
				{

					if(parameter.SoftwaresPackQuestion[parameter.Lvl] < parameter.SoftwaresPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.SoftwaresPack[parameter.Lvl].Question[parameter.SoftwaresPackQuestion[parameter.Lvl]];
							parameter.SoftwaresPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 7)
		{
			for (int i = 0; i < parameter.SuperheroesPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.SuperheroesPackQuestion[parameter.Lvl] + " / " + parameter.SuperheroesPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.SuperheroesPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.SuperheroesPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.SuperheroesPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.SuperheroesPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.SuperheroesPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.SuperheroesPackCorrectAnswers[i] + " / " + parameter.SuperheroesPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.SuperheroesPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.SuperheroesPack.Length)
				{

					if(parameter.SuperheroesPackQuestion[parameter.Lvl] < parameter.SuperheroesPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.SuperheroesPack[parameter.Lvl].Question[parameter.SuperheroesPackQuestion[parameter.Lvl]];
							parameter.SuperheroesPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
					}
				}
				
				
			}
		}
		
		if(parameter.CategoryNumber == 8)
		{
			for (int i = 0; i < parameter.VehiclesPack.Length; i++)
			{
				parameter.ProgressText.text = parameter.VehiclesPackQuestion[parameter.Lvl] + " / " + parameter.VehiclesPack[parameter.Lvl].Question.Length;
				parameter.Progressslider.value = parameter.VehiclesPackQuestion[parameter.Lvl];
				parameter.PackCheckMark[i].SetActive(parameter.VehiclesPackCheckBool[i]);
				parameter.CategoryLevelImageObject[i].overrideSprite = parameter.VehiclesPackPanelImage[i];
				parameter.LevelButtonText[i].text = parameter.VehiclesPackButtonText[i];
				
				parameter.LevelLock[i].SetActive(parameter.VehiclesPackBool[i]);
				parameter.QuestionProgressText[i].text = parameter.VehiclesPackCorrectAnswers[i] + " / " + parameter.VehiclesPack[i].Question.Length;
				parameter.Questionslider[i].value = parameter.VehiclesPackCorrectAnswers[i];
				
				if(parameter.waittime <= 0.0f && parameter.Lvl < parameter.VehiclesPack.Length)
				{
					
					if(parameter.VehiclesPackQuestion[parameter.Lvl] < parameter.VehiclesPack[parameter.Lvl].Question.Length)
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							parameter.IncorrectChoice.Clear();
							parameter.QuestionData = parameter.VehiclesPack[parameter.Lvl].Question[parameter.VehiclesPackQuestion[parameter.Lvl]];
							parameter.VehiclesPackQuestion[parameter.Lvl]++;
							passivefunction.ResetQuestionComponent();
							passivefunction.TurnOnButtons();
						}
					}
					else
					{
						parameter.TransitionTime -= Time.deltaTime;
						if(parameter.TransitionTime <= 0.0f)
						{
							passivefunction.LevelCompleted();
							passivefunction.ResetLevel();
							
						}
					}
				}
				
				
			}
		}
		
		
		

		if(!parameter.MaxScoreBool)
		{
			passivefunction.SetMaxScore();
		}
		
		
	}

	
	public void OptionButtonColorChange()
	{
		for (int i = 0; i < parameter.Choices.Length; i++)
		{
			if(parameter.CorrectAnswer[i])
			{
				parameter.waittime -= Time.deltaTime;
				for (int j = 0; j < 4; j++)
				{
					if(!parameter.QuestionData.isAnswer[j])
					{
						parameter.Choices[j].SetActive(false);
					}
				}
				if(parameter.waittime <= 0.0f)
				{
					AM.PlayCorrectButtonClick();
					parameter.waittime = 0.0f;
					parameter.sprState[i] = parameter.ChoicesButton[i].spriteState;
					parameter.sprState[i].disabledSprite = parameter.BasicGuessData.Correct;
					parameter.ChoicesButton[i].spriteState = parameter.sprState[i];
					passivefunction.GuessLogoScore();
				}
				
			}
			
			if(parameter.InCorrectAnswer[i])
			{
				parameter.waittime -= Time.deltaTime;
				if(parameter.waittime <= 0.0f)
				{
					AM.PlayWrongButtonClick();
					parameter.waittime = 0.0f;		
					parameter.sprState[i] = parameter.ChoicesButton[i].spriteState;
					parameter.sprState[i].disabledSprite = parameter.BasicGuessData.InCorrect;
					parameter.ChoicesButton[i].spriteState = parameter.sprState[i];
				}

			}
			
			
		}
	}
	
	
	

}

















