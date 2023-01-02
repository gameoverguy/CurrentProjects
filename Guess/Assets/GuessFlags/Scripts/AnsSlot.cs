using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnsSlot : MonoBehaviour
{
    public int index=0;
    public bool isVacant = true;
    public Text slotText;
	public char character;
 
    int returningIndex = 0;

    public void OnClick()
    {
        if (!isVacant)
        {
            isVacant = true;
			QSlot.Instance.ReturnSlot(returningIndex, slotText.text);
            slotText.text = "";
         }
		if (slotText.text == "?") 
		{
			index = transform.GetSiblingIndex ();
			GameManager.Instance.Click (index);
		}
    }
    public void FillSlot(string s, int id)
    {
        isVacant = false;
        slotText.text = s;
        returningIndex = id;
		GameManager.Instance.CheckWord ();
    }
	private static AnsSlot _instance;

	public static AnsSlot Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<AnsSlot>();
			}
			return _instance;
		}
	}
}
