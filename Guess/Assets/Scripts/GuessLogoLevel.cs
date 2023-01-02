using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "New GuessLogoLevel", menuName = "GuessLogoLevel")]

public class GuessLogoLevel : ScriptableObject
{
	public TextMeshProUGUI[] OptionText;
	public Button[] Option;
	public Image GuessImage;
	
	public GuessData[] Question;
	
}