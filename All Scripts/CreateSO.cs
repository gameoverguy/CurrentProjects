using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.UI;
using System.Drawing;
using System.Collections.Generic;


public class CreateSO : MonoBehaviour
{
	public TextAsset TextAssetDataCSV;
	public GuessData[] SO;

	public void CreateMyAsset()
	{
		for (int i = 1; i < 16; i++)
		{
			SO[i-1] = ScriptableObject.CreateInstance<GuessData>();
			string SOname = "P03Q" + i;
			string AssetPath = UnityEditor.AssetDatabase.GenerateUniqueAssetPath("Assets/ScriptableObjects/ZNew/" + SOname + ".asset");
			AssetDatabase.CreateAsset(SO[i-1], AssetPath);
			EditorUtility.FocusProjectWindow();
			EditorUtility.SetDirty(SO[i-1]);
			AssetDatabase.SaveAssets();
			Selection.activeObject = SO[i-1];
		}
		
		DataCSV();
	}
	
	
	public void DataCSV()
	{
		string[] data = TextAssetDataCSV.text.Split(new string[] { "," , "/n" }, StringSplitOptions.None);
		
		int tablesize = data.Length / 8 - 1;

		for (int i = 0; i < 15; i++)
		{
			SO[i].isAnswer[0] = bool.Parse(data[9 * (i + 1) + 1]);
			SO[i].isAnswer[1] = bool.Parse(data[9 * (i + 1) + 2]);
			SO[i].isAnswer[2] = bool.Parse(data[9 * (i + 1) + 3]);
			SO[i].isAnswer[3] = bool.Parse(data[9 * (i + 1) + 4]);
			
			string st = data[9 * (i + 1) + 5];
			string imagename = st;

			var guesssprite = Resources.Load<Sprite>("GuessCategoryImages/VehicleLogos/Pack3/" + imagename + "");
			Debug.Log(guesssprite);

			SO[i].GuessImage = guesssprite;
			SO[i].OptionText[0] = data[9 * (i + 1) + 6];
			SO[i].OptionText[1] = data[9 * (i + 1) + 7];
			SO[i].OptionText[2] = data[9 * (i + 1) + 8];
			SO[i].OptionText[3] = data[9 * (i + 1) + 9];
			
			EditorUtility.SetDirty(SO[i]);
			AssetDatabase.SaveAssets();
			Selection.activeObject = SO[i];

		}
	}
	
	
	
}


















