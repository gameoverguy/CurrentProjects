using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GuessData", menuName = "GuessData")]

public class GuessData : ScriptableObject
{
	
	public string[] OptionText = new string[4];
	public Sprite GuessImage;
	public bool[] isAnswer = new bool[4];
	public bool Answered;
	
	public Sprite Regular;
	public Sprite Correct;
	public Sprite InCorrect;
	public Sprite Chosen;
	public Sprite Orange;

}