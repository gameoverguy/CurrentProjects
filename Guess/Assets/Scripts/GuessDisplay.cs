using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuessDisplay : MonoBehaviour 
{

	public GuessData Level01guessdata;
	public GuessData Level02guessdata;
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
	public bool Level01QAnswered;
	public bool Level02QAnswered;
	public GuessData[] Level01Question;
	public GuessData[] Level02Question;

	public ColorBlock[] cb;
	public ColorBlock[] Level01cb;
	public ColorBlock[] Level02cb;
	
	public int Level01Q;
	public int Level02Q;
	
	public GameObject[] level;
	public int Lvl;
	

    // Use this for initialization
    void Start ()
	{

		Level01Q = 1;
		Level02Q = 1;
		Lvl = 1;
		waittime = 2.0f;
		TransitionTime = 2.0f;
		Level01QAnswered = false;
		Level02QAnswered = false;
		
		Level01GuessImage.sprite = Level01guessdata.GuessImage;
		
		/*
		for (int i = 0; i < Level01cb.Length; i++)
		{
			Level01OptionText[i].text = Level01guessdata.OptionText[i];
			Level01cb[i] = Level01Option[i].colors;
			Level01cb[i].selectedColor = Level01guessdata.Selected;
			Level01cb[i].pressedColor = Level01guessdata.Selected;
			Level01cb[i].normalColor = Level01guessdata.normal;
			Level01cb[i].disabledColor = Level01guessdata.normal;
			Level01Option[i].colors = Level01cb[i];
		}
		*/
		
		for (int i = 0; i < cb.Length; i++)
		{
			Level01OptionText[i].text = Level01guessdata.OptionText[i];
			cb[i] = Level01Option[i].colors;
			cb[i].selectedColor = Level01guessdata.Selected;
			cb[i].pressedColor = Level01guessdata.Selected;
			cb[i].normalColor = Level01guessdata.normal;
			cb[i].disabledColor = Level01guessdata.normal;
			Level01Option[i].colors = cb[i];
		}
		
		
	}
	
	public void CheckOption01()
	{
		
		
		if(Lvl == 1)
		{
			
			cb[0].normalColor = Level01guessdata.Selected;
			cb[0].selectedColor = Level01guessdata.Selected;
			cb[0].disabledColor = Level01guessdata.Selected;
			Level01Option[0].colors = cb[0];
			
			/*
			Level01cb[0].normalColor = Level01guessdata.Selected;
			Level01cb[0].selectedColor = Level01guessdata.Selected;
			Level01cb[0].disabledColor = Level01guessdata.Selected;
			Level01Option[0].colors = Level01cb[0];
			*/
			
			
			TurnoffButtons();
			Level01QAnswered = true;
		
			if(Level01guessdata.isAnswer[0])
			{
				CorrectAnswer[0] = true;
			}
			else
			{
				InCorrectAnswer[0] = true;
			}
		}
		
		
		if(Lvl == 2)
		{
			cb[0] = Level02Option[0].colors;
			cb[0].normalColor = Level02guessdata.Selected;
			cb[0].selectedColor = Level02guessdata.Selected;
			cb[0].disabledColor = Level02guessdata.Selected;
			Level02Option[0].colors = cb[0];
			
			/*
			Level02cb[0] = Level02Option[0].colors;
			Level02cb[0].normalColor = Level02guessdata.Selected;
			Level02cb[0].selectedColor = Level02guessdata.Selected;
			Level02cb[0].disabledColor = Level02guessdata.Selected;
			Level02Option[0].colors = Level02cb[0];
			*/
			
			TurnoffButtons();
			Level02QAnswered = true;
		
			if(Level02guessdata.isAnswer[0])
			{
				CorrectAnswer[0] = true;
			}
			else
			{
				InCorrectAnswer[0] = true;
			}
		}
		
		
		
		
	}
	
	public void CheckOption02()
	{
		if(Lvl == 1)
		{
			cb[1].normalColor = Level01guessdata.Selected;
			cb[1].selectedColor = Level01guessdata.Selected;
			cb[1].disabledColor = Level01guessdata.Selected;
			Level01Option[1].colors = cb[1];
			
			/*
			Level01cb[1].normalColor = Level01guessdata.Selected;
			Level01cb[1].selectedColor = Level01guessdata.Selected;
			Level01cb[1].disabledColor = Level01guessdata.Selected;
			Level01Option[1].colors = Level01cb[1];
			*/
			
			
			TurnoffButtons();
			Level01QAnswered = true;
		
			if(Level01guessdata.isAnswer[1])
			{
				CorrectAnswer[1] = true;
			}
			else
			{
				InCorrectAnswer[1] = true;
			}
			
		}
		
		if(Lvl == 2)
		{
			cb[1] = Level02Option[1].colors;
			cb[1].normalColor = Level02guessdata.Selected;
			cb[1].selectedColor = Level02guessdata.Selected;
			cb[1].disabledColor = Level02guessdata.Selected;
			Level02Option[1].colors = cb[1];
			
			/*
			Level02cb[1] = Level02Option[1].colors;
			Level02cb[1].normalColor = Level02guessdata.Selected;
			Level02cb[1].selectedColor = Level02guessdata.Selected;
			Level02cb[1].disabledColor = Level02guessdata.Selected;
			Level02Option[1].colors = Level02cb[1];
			*/
			
			TurnoffButtons();
			Level02QAnswered = true;
		
			if(Level02guessdata.isAnswer[1])
			{
				CorrectAnswer[1] = true;
			}
			else
			{
				InCorrectAnswer[1] = true;
			}
		}
		
		
		

		
	}
	
	public void CheckOption03()
	{
		
		if(Lvl == 1)
		{
			
			cb[2].normalColor = Level01guessdata.Selected;
			cb[2].selectedColor = Level01guessdata.Selected;
			cb[2].disabledColor = Level01guessdata.Selected;
			Level01Option[2].colors = cb[2];
			
			/*
			Level01cb[2].normalColor = Level01guessdata.Selected;
			Level01cb[2].selectedColor = Level01guessdata.Selected;
			Level01cb[2].disabledColor = Level01guessdata.Selected;
			Level01Option[2].colors = Level01cb[2];
			*/
			
			
			TurnoffButtons();
			Level01QAnswered = true;
		
			if(Level01guessdata.isAnswer[2])
			{
				CorrectAnswer[2] = true;
			}
			else
			{
				InCorrectAnswer[2] = true;
			}
		}
		
		if(Lvl == 2)
		{
			cb[2] = Level02Option[2].colors;
			cb[2].normalColor = Level02guessdata.Selected;
			cb[2].selectedColor = Level02guessdata.Selected;
			cb[2].disabledColor = Level02guessdata.Selected;
			Level02Option[2].colors = cb[2];
			
			/*
			Level02cb[2] = Level02Option[2].colors;
			Level02cb[2].normalColor = Level02guessdata.Selected;
			Level02cb[2].selectedColor = Level02guessdata.Selected;
			Level02cb[2].disabledColor = Level02guessdata.Selected;
			Level02Option[2].colors = Level02cb[2];
			*/
			
			TurnoffButtons();
			Level02QAnswered = true;
		
			if(Level02guessdata.isAnswer[2])
			{
				CorrectAnswer[2] = true;
			}
			else
			{
				InCorrectAnswer[2] = true;
			}
		}
		
		
		
		
	}
	
	public void CheckOption04()
	{
		
		if(Lvl == 1)
		{
			cb[3].normalColor = Level01guessdata.Selected;
			cb[3].selectedColor = Level01guessdata.Selected;
			cb[3].disabledColor = Level01guessdata.Selected;
			Level01Option[3].colors = cb[3];
			
			/*
			Level01cb[3].normalColor = Level01guessdata.Selected;
			Level01cb[3].selectedColor = Level01guessdata.Selected;
			Level01cb[3].disabledColor = Level01guessdata.Selected;
			Level01Option[3].colors = Level01cb[3];
			*/
			
			TurnoffButtons();
			Level01QAnswered = true;
		
			if(Level01guessdata.isAnswer[3])
			{
				CorrectAnswer[3] = true;
			}
			else
			{
				InCorrectAnswer[3] = true;
			}
		}
		
		if(Lvl == 2)
		{
			cb[3] = Level02Option[3].colors;
			cb[3].normalColor = Level02guessdata.Selected;
			cb[3].selectedColor = Level02guessdata.Selected;
			cb[3].disabledColor = Level02guessdata.Selected;
			Level02Option[3].colors = cb[3];
			
			/*
			Level02cb[3] = Level02Option[3].colors;
			Level02cb[3].normalColor = Level02guessdata.Selected;
			Level02cb[3].selectedColor = Level02guessdata.Selected;
			Level02cb[3].disabledColor = Level02guessdata.Selected;
			Level02Option[3].colors = Level02cb[3];
			*/
			
			
			TurnoffButtons();
			Level02QAnswered = true;
		
			if(Level02guessdata.isAnswer[3])
			{
				CorrectAnswer[3] = true;
			}
			else
			{
				InCorrectAnswer[3] = true;
			}
		}
		
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	public void Update()
	{
		if(CorrectAnswer[0] && Lvl ==1)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[0].selectedColor = Level01guessdata.Green;
				cb[0].normalColor = Level01guessdata.Green;
				cb[0].disabledColor = Level01guessdata.Green;
				Level01Option[0].colors = cb[0];
				
				
				/*
				Level01cb[0].selectedColor = Level01guessdata.Green;
				Level01cb[0].normalColor = Level01guessdata.Green;
				Level01cb[0].disabledColor = Level01guessdata.Green;
				Level01Option[0].colors = Level01cb[0];
				*/
				waittime = 0.0f;
			}

		}
		
		if(CorrectAnswer[0] && Lvl ==2)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[0] = Level02Option[0].colors;
				cb[0].selectedColor = Level02guessdata.Green;
				cb[0].normalColor = Level02guessdata.Green;
				cb[0].disabledColor = Level02guessdata.Green;
				Level02Option[0].colors = cb[0];
				
				/*
				Level02cb[0] = Level02Option[0].colors;
				Level02cb[0].selectedColor = Level02guessdata.Green;
				Level02cb[0].normalColor = Level02guessdata.Green;
				Level02cb[0].disabledColor = Level02guessdata.Green;
				Level02Option[0].colors = Level02cb[0];
				*/
				
				
				waittime = 0.0f;
			}
		}
		
		
		
		if(CorrectAnswer[1] && Lvl == 1)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[1].selectedColor = Level01guessdata.Green;
				cb[1].normalColor = Level01guessdata.Green;
				cb[1].disabledColor = Level01guessdata.Green;
				Level01Option[1].colors = cb[1];
				
				/*
				Level01cb[1].selectedColor = Level01guessdata.Green;
				Level01cb[1].normalColor = Level01guessdata.Green;
				Level01cb[1].disabledColor = Level01guessdata.Green;
				Level01Option[1].colors = Level01cb[1];
				*/
				waittime = 0.0f;
			}
		}
		
		if(CorrectAnswer[1] && Lvl == 2)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[1] = Level02Option[1].colors;
				cb[1].selectedColor = Level02guessdata.Green;
				cb[1].normalColor = Level02guessdata.Green;
				cb[1].disabledColor = Level02guessdata.Green;
				Level02Option[1].colors = cb[1];
				
				/*
				Level02cb[1] = Level02Option[1].colors;
				Level02cb[1].selectedColor = Level02guessdata.Green;
				Level02cb[1].normalColor = Level02guessdata.Green;
				Level02cb[1].disabledColor = Level02guessdata.Green;
				Level02Option[1].colors = Level02cb[1];
				*/
				
				
				waittime = 0.0f;
			}
		}


		
		
		if(CorrectAnswer[2] && Lvl == 1)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[2].selectedColor = Level01guessdata.Green;
				cb[2].normalColor = Level01guessdata.Green;
				cb[2].disabledColor = Level01guessdata.Green;
				Level01Option[2].colors = cb[2];
				
				/*
				Level01cb[2].selectedColor = Level01guessdata.Green;
				Level01cb[2].normalColor = Level01guessdata.Green;
				Level01cb[2].disabledColor = Level01guessdata.Green;
				Level01Option[2].colors = Level01cb[2];
				*/
				waittime = 0.0f;
			}
			
		}
		
		
		if(CorrectAnswer[2] && Lvl == 2)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[2] = Level02Option[2].colors;
				cb[2].selectedColor = Level02guessdata.Green;
				cb[2].normalColor = Level02guessdata.Green;
				cb[2].disabledColor = Level02guessdata.Green;
				Level02Option[2].colors = cb[2];
				
				/*
				Level02cb[2] = Level02Option[2].colors;
				Level02cb[2].selectedColor = Level02guessdata.Green;
				Level02cb[2].normalColor = Level02guessdata.Green;
				Level02cb[2].disabledColor = Level02guessdata.Green;
				Level02Option[2].colors = Level02cb[2];
				*/
				
				waittime = 0.0f;
			}
			
		}
		
		
		
		if(CorrectAnswer[3] && Lvl ==1)
		{		
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[3].selectedColor = Level01guessdata.Green;
				cb[3].normalColor = Level01guessdata.Green;
				cb[3].disabledColor = Level01guessdata.Green;
				Level01Option[3].colors = cb[3];
				
				/*
				Level01cb[3].selectedColor = Level01guessdata.Green;
				Level01cb[3].normalColor = Level01guessdata.Green;
				Level01cb[3].disabledColor = Level01guessdata.Green;
				Level01Option[3].colors = Level01cb[3];
				*/
				waittime = 0.0f;
			}
			
			
		}
		else if(CorrectAnswer[3] && Lvl ==2)
		{
			waittime -= Time.deltaTime;
			
			if(waittime <= 0.0f)
			{
				cb[3] = Level02Option[3].colors;
				cb[3].selectedColor = Level02guessdata.Green;
				cb[3].normalColor = Level02guessdata.Green;
				cb[3].disabledColor = Level02guessdata.Green;
				Level02Option[3].colors = cb[3];
				
				/*
				Level02cb[3] = Level02Option[3].colors;
				Level02cb[3].selectedColor = Level02guessdata.Green;
				Level02cb[3].normalColor = Level02guessdata.Green;
				Level02cb[3].disabledColor = Level02guessdata.Green;
				Level02Option[3].colors = Level02cb[3];
				*/
				
				
				waittime = 0.0f;
			}
		}
		
		if(InCorrectAnswer[0])
		{
			if(Lvl ==1)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level01cb[0].selectedColor = Level01guessdata.Red;
					Level01cb[0].normalColor = Level01guessdata.Red;
					Level01cb[0].disabledColor = Level01guessdata.Red;
					Level01Option[0].colors = Level01cb[0];
					
					/*
					*/
					waittime = 0.0f;
				}
			}
			if(Lvl ==2)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level02cb[0].selectedColor = Level02guessdata.Red;
					Level02cb[0].normalColor = Level02guessdata.Red;
					Level02cb[0].disabledColor = Level02guessdata.Red;
					Level02Option[0].colors = Level02cb[0];
					waittime = 0.0f;
				}
			}
			
			
		}
		
		if(InCorrectAnswer[1])
		{
			if(Lvl ==1)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level01cb[1].selectedColor = Level01guessdata.Red;
					Level01cb[1].normalColor = Level01guessdata.Red;
					Level01cb[1].disabledColor = Level01guessdata.Red;
					Level01Option[1].colors = Level01cb[1];
					
					/*
					*/
					waittime = 0.0f;
				}
			}
			
			if(Lvl ==2)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level02cb[1].selectedColor = Level02guessdata.Red;
					Level02cb[1].normalColor = Level02guessdata.Red;
					Level02cb[1].disabledColor = Level02guessdata.Red;
					Level02Option[1].colors = Level02cb[1];
					waittime = 0.0f;
				}
			}
			
		}
		
		if(InCorrectAnswer[2])
		{
			if(Lvl ==1)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level01cb[2].selectedColor = Level01guessdata.Red;
					Level01cb[2].normalColor = Level01guessdata.Red;
					Level01cb[2].disabledColor = Level01guessdata.Red;
					Level01Option[2].colors = Level01cb[2];
					
					/*
					*/
					waittime = 0.0f;
				}
			}
			if(Lvl ==2)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level02cb[2].selectedColor = Level02guessdata.Red;
					Level02cb[2].normalColor = Level02guessdata.Red;
					Level02cb[2].disabledColor = Level02guessdata.Red;
					Level02Option[2].colors = Level02cb[2];
					waittime = 0.0f;
				}
			}
			
		}
		
		if(InCorrectAnswer[3])
		{
			if(Lvl ==1)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level01cb[3].selectedColor = Level01guessdata.Red;
					Level01cb[3].normalColor = Level01guessdata.Red;
					Level01cb[3].disabledColor = Level01guessdata.Red;
					Level01Option[3].colors = Level01cb[3];
					
					/*
					*/
					waittime = 0.0f;
				}
			}
			
			if(Lvl ==2)
			{
				waittime -= Time.deltaTime;
			
				if(waittime <= 0.0f)
				{
					Level02cb[3].selectedColor = Level02guessdata.Red;
					Level02cb[3].normalColor = Level02guessdata.Red;
					Level02cb[3].disabledColor = Level02guessdata.Red;
					Level02Option[3].colors = Level02cb[3];
					waittime = 0.0f;
				}
			}
			
		}
		
		if(Level01QAnswered)
		{
			if(Level01Q < Level01Question.Length && Lvl == 1 && waittime == 0.0f)
			{
				TransitionTime -= Time.deltaTime;
			
				if(TransitionTime <= 0.0f)
				{
					
					if(Lvl == 1)
					{
						Level01QAnswered = false;
						Level01guessdata = Level01Question[Level01Q];
						LoadNextLevel01Question();
						TurnOnButtons();
						Level01Q++;
					}
						
				}
			}
			else if(Lvl < level.Length && waittime == 0.0f)
			{
				
				TransitionTime -= Time.deltaTime;
				
				if(TransitionTime <= 0.0f)
				{
					level[Lvl-1].SetActive(false);
					ResetLevel();
					Lvl++;
					level[Lvl-1].SetActive(true);
				}

			}
		}
			
		if(Level02QAnswered)
		{
			if(Level02Q < Level02Question.Length && Lvl == 2 && waittime == 0.0f)
			{
				TransitionTime -= Time.deltaTime;
			
				if(TransitionTime <= 0.0f)
				{
					if(Lvl == 2)
					{
						Level02QAnswered = false;
						Level02guessdata = Level02Question[Level02Q];
						LoadNextLevel02Question();
						TurnOnButtons();
						Level02Q++;
					}

				}
			}
			else if(Lvl < level.Length && waittime == 0.0f)
			{
				TransitionTime -= Time.deltaTime;
				
				if(TransitionTime <= 0.0f)
				{
					level[Lvl-1].SetActive(false);
					ResetLevel();
					Lvl++;
					level[Lvl-1].SetActive(true);
				}

			}
		}
			
	}
	
	private void TurnoffButtons()
	{
		if(Lvl == 1)
		{
			for (int i = 0; i < Level01Option.Length; i++)
			{
				Level01Option[i].interactable = false;
			}

		}
		
		if(Lvl == 2)
		{
			for (int i = 0; i < Level02Option.Length; i++)
			{
				Level02Option[i].interactable = false;
			}
		}
		
	}
	
	private void TurnOnButtons()
	{
		
		if(Lvl == 1)
		{
			for (int i = 0; i < Level01Option.Length; i++)
			{
				Level01Option[i].interactable = true;
			}
			
		}
		
		if(Lvl == 2)
		{
			for (int i = 0; i < Level02Option.Length; i++)
			{
				Level02Option[i].interactable = true;
			}
		}
		
	}
	
	private void ResetLevel()
	{

		waittime = 2.0f;
		TransitionTime = 2.0f;
		
		Level01QAnswered = false;
		Level02QAnswered = false;

		
		Level02GuessImage.sprite = Level02guessdata.GuessImage;
		
		for (int i = 0; i < cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level02OptionText[i].text = Level02guessdata.OptionText[i];
			cb[i] = Level02Option[i].colors;
			cb[i].selectedColor = Level02guessdata.Selected;
			cb[i].pressedColor = Level02guessdata.Selected;
			cb[i].normalColor = Level02guessdata.normal;
			cb[i].disabledColor = Level02guessdata.normal;
			Level02Option[i].colors = cb[i];
		}
		
		/*
		for (int i = 0; i < Level02cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level02OptionText[i].text = Level02guessdata.OptionText[i];
			Level02cb[i] = Level02Option[i].colors;
			Level02cb[i].selectedColor = Level02guessdata.Selected;
			Level02cb[i].pressedColor = Level02guessdata.Selected;
			Level02cb[i].normalColor = Level02guessdata.normal;
			Level02cb[i].disabledColor = Level02guessdata.normal;
			Level02Option[i].colors = Level02cb[i];
		}
		*/
		
	}
	
	private void LoadNextLevel01Question()
	{
		waittime = 2.0f;
		TransitionTime = 2.0f;
		
		Level01GuessImage.sprite = Level01guessdata.GuessImage;
		
		for (int i = 0; i < Level01cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level01OptionText[i].text = Level01guessdata.OptionText[i];
			
			cb[i].selectedColor = Level01guessdata.Selected;
			cb[i].pressedColor = Level01guessdata.Selected;
			cb[i].normalColor = Level01guessdata.normal;
			cb[i].disabledColor = Level01guessdata.normal;
			Level01Option[i].colors = cb[i];
			/*
			Level01cb[i].selectedColor = Level01guessdata.Selected;
			Level01cb[i].pressedColor = Level01guessdata.Selected;
			Level01cb[i].normalColor = Level01guessdata.normal;
			Level01cb[i].disabledColor = Level01guessdata.normal;
			Level01Option[i].colors = Level01cb[i];
			*/
		}

	}
	
	
	private void LoadNextLevel02Question()
	{
		waittime = 2.0f;
		TransitionTime = 2.0f;
		
		Level02GuessImage.sprite = Level02guessdata.GuessImage;
		
		for (int i = 0; i < Level02cb.Length; i++)
		{
			CorrectAnswer[i] = false;
			InCorrectAnswer[i] = false;
			Level02OptionText[i].text = Level02guessdata.OptionText[i];
			cb[i] = Level02Option[i].colors;
			cb[i].selectedColor = Level02guessdata.Selected;
			cb[i].pressedColor = Level02guessdata.Selected;
			cb[i].normalColor = Level02guessdata.normal;
			cb[i].disabledColor = Level02guessdata.normal;
			Level02Option[i].colors = cb[i];
			
			/*
			Level02cb[i] = Level02Option[i].colors;
			Level02cb[i].selectedColor = Level02guessdata.Selected;
			Level02cb[i].pressedColor = Level02guessdata.Selected;
			Level02cb[i].normalColor = Level02guessdata.normal;
			Level02cb[i].disabledColor = Level02guessdata.normal;
			Level02Option[i].colors = Level02cb[i];
			*/
		}


	}

}
