using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "New BasicData", menuName = "BasicData")]

public class BasicData : ScriptableObject
{
	public Sprite Regular;
	public Sprite Correct;
	public Sprite InCorrect;
	public Sprite Chosen;
	public Sprite Orange;

}