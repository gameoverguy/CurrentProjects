using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "New Category", menuName = "Category")]

public class Category : ScriptableObject
{
	public CategoryLevel[] Level;
	
	public int CategoryNumber;
}