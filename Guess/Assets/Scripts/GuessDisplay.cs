using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuessDisplay : MonoBehaviour 
{
	public GuessData BasicGuessData;
	public GuessData LevelGuessData;
	
	public Button[] Level01Option;
	public Button[] Level02Option;
	
	public TextMeshProUGUI[] Level01OptionText;
	public TextMeshProUGUI[] Level02OptionText;
	
	public Image Level01GuessImage;
	public Image Level02GuessImage;
	
	public float waittime;
	public float TransitionTime;
	public bool[] CorrectAnswer;
	public bool[] InCorrectAnswer;


	
	public GuessLogoLevel[] guesslogolevel;

	public ColorBlock[] cb;

	public int[] LevelQuestion;
	
	public int Lvl;

	

    // Use this for initialization
    void Start ()
	{

		LevelQuestion[0] = 1;
		LevelQuestion[1] = 1;
		
		Lvl = 0;
		waittime = 1.0f;
		TransitionTime = 1.0f;

		Level01GuessImage.sprite = LevelGuessData.GuessImage;
		
		for (int i = 0; i < cb.Length; i++)
		{
			Level01OptionText[i].text = LevelGuessData.OptionText[i];
			cb[i] = Level01Option[i].colors;
			cb[i].selectedColor = BasicGuessData.Selected;
			cb[i].pressedColor = BasicGuessData.Selected;
			cb[i].normalColor = BasicGuessData.normal;
			cb[i].disabledColor = BasicGuessData.normal;
			Level01Option[i].colors = cb[i];
		}
	}
	
	public void CheckOption01()
	{
		cb[0] = Level01Option[0].colors;
		cb[0].normalColor = LevelGuessData.Selected;
		cb[0].selectedColor = LevelGuessData.Selected;
		cb[0].disabledColor = LevelGuessData.Selected;
		Level01Option[0].colors = cb[0];
			
		TurnoffButtons();

		if(LevelGuessData.isAnswer[0])
		{
			CorrectAnswer[0] = true;
		}
		else
		{
			InCorrectAnswer[0] = true;
		}
	}
	
	public void CheckOption02()
	{
		cb[1] = Level01Option[1].colors;
		cb[1].normalColor = LevelGuessData.Selected;
		cb[1].selectedColor = LevelGuessData.Selected;
		cb[1].disabledColor = LevelGuessData.Selected;
		Level01Option[1].colors = cb[1];
			
		TurnoffButtons();

		if(LevelGuessData.isAnswer[1])
		{
			CorrectAnswer[1] = true;
		}
		else
		{
			InCorrectAnswer[1] = true;
		}
	}
	
	public void CheckOption03()
	{
		cb[2] = Level01Option[2].colors;
		cb[2].normalColor = LevelGuessData.Selected;
		cb[2].selectedColor = LevelGuessData.Selected;
		cb[2].disabledColor = LevelGuessData.Selected;
		Level01Option[2].colors = cb[2];
			
		TurnoffButtons();

		if(LevelGuessData.isAnswer[2])
		{
			CorrectAnswer[2] = true;
		}
		else
		{
			InCorrectAnswer[2] = true;
		}
	}
	
	public void CheckOption04()
	{
		cb[3] = Level01Option[3].colors;
		cb[3].normalColor = LevelGuessData.Selected;
		cb[3].selectedColor = LevelGuessData.Selected;
		cb[3].disabledColor = LevelGuessData.Selected;
		Level01Option[3].colors = cb[3];
	
		TurnoffButtons();

		if(LevelGuessData.isAnswer[3])
		{
			CorrectAnswer[3] = true;
		}
		else
		{
			InCorrectAnswer[3] = true;
		}
	}
	


	public void Update()
	{
		if(CorrectAnswer[0])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[0] = Level01Option[0].colors;
				cb[0].selectedColor = LevelGuessData.Green;
				cb[0].normalColor = LevelGuessData.Green;
				cb[0].disabledColor = LevelGuessData.Green;
				Level01Option[0].colors = cb[0];
				
				waittime = 0.0f;
			}
		}
		
		if(CorrectAnswer[1])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[1] = Level01Option[1].colors;
				cb[1].selectedColor = LevelGuessData.Green;
				cb[1].normalColor = LevelGuessData.Green;
				cb[1].disabledColor = LevelGuessData.Green;
				Level01Option[1].colors = cb[1];
				
				waittime = 0.0f;
			}
		}

		if(CorrectAnswer[2])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[2] = Level01Option[2].colors;
				cb[2].selectedColor = LevelGuessData.Green;
				cb[2].normalColor = LevelGuessData.Green;
				cb[2].disabledColor = LevelGuessData.Green;
				Level01Option[2].colors = cb[2];
				
				waittime = 0.0f;
			}
			
		}
		
		if(CorrectAnswer[3])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[3] = Level01Option[3].colors;
				cb[3].selectedColor = LevelGuessData.Green;
				cb[3].normalColor = LevelGuessData.Green;
				cb[3].disabledColor = LevelGuessData.Green;
				Level01Option[3].colors = cb[3];
				
				waittime = 0.0f;
			}
		}
		
		
		if(InCorrectAnswer[0])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[0] = Level01Option[0].colors;
				cb[0].selectedColor = LevelGuessData.Red;
				cb[0].normalColor = LevelGuessData.Red;
				cb[0].disabledColor = LevelGuessData.Red;
				Level01Option[0].colors = cb[0];
					
				waittime = 0.0f;
			}
		}
		
		if(InCorrectAnswer[1])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[1] = Level01Option[1].colors;
				cb[1].selectedColor = LevelGuessData.Red;
				cb[1].normalColor = LevelGuessData.Red;
				cb[1].disabledColor = LevelGuessData.Red;
				Level01Option[1].colors = cb[1];
					
				waittime = 0.0f;
			}
		}
		
		if(InCorrectAnswer[2])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[2] = Level01Option[2].colors;
				cb[2].selectedColor = LevelGuessData.Red;
				cb[2].normalColor = LevelGuessData.Red;
				cb[2].disabledColor = LevelGuessData.Red;
				Level01Option[2].colors = cb[2];

				waittime = 0.0f;
			}
		}
		
		if(InCorrectAnswer[3])
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[3] = Level01Option[3].colors;
				cb[3].selectedColor = LevelGuessData.Red;
				cb[3].normalColor = LevelGuessData.Red;
				cb[3].disabledColor = LevelGuessData.Red;
				Level01Option[3].colors = cb[3];

				waittime = 0.0f;
			}
		}
		
		
		if(waittime <= 0.0f && Lvl < 2)
		{
			if(LevelQuestion[Lvl] < guesslogolevel[Lvl].Question.Length)
			{
				TransitionTime -= Time.deltaTime;
			
				if(TransitionTime <= 0.0f)
				{
					LevelGuessData = guesslogolevel[Lvl].Question[LevelQuestion[Lvl]];
					LoadNextLevel01Question();
					TurnOnButtons();

					LevelQuestion[Lvl]++;
				}
			}
			else
			{
				TransitionTime -= Time.deltaTime;
				
				if(TransitionTime <= 0.0f)
				{
					TurnOnButtons();
					Debug.Log("1ok");
					Lvl++;
					
					if(Lvl < 2)
					ResetLevel();
				}
			}
			
		}
		
		
		
		
	}
	
	private void TurnoffButtons()
	{	
		for (int i = 0; i < Level01Option.Length; i++)
		{
			Level01Option[i].interactable = false;
		}
	}
	
	private void TurnOnButtons()
	{
		for (int i = 0; i < Level01Option.Length; i++)
		{
			Level01Option[i].interactable = true;
		}
	}
	
	private void ResetLevel()
	{

		waittime = 1.0f;
		TransitionTime = 1.0f;
		
		
		LevelGuessData = guesslogolevel[Lvl].Question[0];
		
		Level01GuessImage.sprite = LevelGuessData.GuessImage;
		
		for (int i = 0; i < cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level01OptionText[i].text = LevelGuessData.OptionText[i];
			cb[i] = Level02Option[i].colors;
			cb[i].selectedColor = LevelGuessData.Selected;
			cb[i].pressedColor = LevelGuessData.Selected;
			cb[i].normalColor = LevelGuessData.normal;
			cb[i].disabledColor = LevelGuessData.normal;
			Level01Option[i].colors = cb[i];
		}
		
	}
	
	private void LoadNextLevel01Question()
	{
		
		
		waittime = 1.0f;
		TransitionTime = 1.0f;
		
		
		
		Level01GuessImage.sprite = LevelGuessData.GuessImage;
		
		for (int i = 0; i < cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level01OptionText[i].text = LevelGuessData.OptionText[i];
			cb[i].selectedColor = LevelGuessData.Selected;
			cb[i].pressedColor = LevelGuessData.Selected;
			cb[i].normalColor = LevelGuessData.normal;
			cb[i].disabledColor = LevelGuessData.normal;
			Level01Option[i].colors = cb[i];

		}

	}
	
	
	private void LoadNextLevel02Question()
	{
		waittime = 1.0f;
		TransitionTime = 1.0f;
		
		Level01GuessImage.sprite = LevelGuessData.GuessImage;
		
		for (int i = 0; i < cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level01OptionText[i].text = LevelGuessData.OptionText[i];
			cb[i] = Level01Option[i].colors;
			cb[i].selectedColor = LevelGuessData.Selected;
			cb[i].pressedColor = LevelGuessData.Selected;
			cb[i].normalColor = LevelGuessData.normal;
			cb[i].disabledColor = LevelGuessData.normal;
			Level01Option[i].colors = cb[i];

		}


	}

}
