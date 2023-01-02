using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GuessData", menuName = "GuessData")]

public class GuessData : ScriptableObject
{

	public string[] OptionText;
	public Sprite GuessImage;
	public bool[] isAnswer;
	public Color Selected;
	public Color normal;
	public Color Green;
	public Color Red;
	
}

//FB9717