using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "New CategoryLevel", menuName = "CategoryLevell")]

public class CategoryLevel : ScriptableObject
{
	public GuessData[] Question;
	
	public int level;
}