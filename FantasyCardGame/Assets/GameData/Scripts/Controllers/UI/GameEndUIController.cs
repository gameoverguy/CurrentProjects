using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameEndUIController : MonoBehaviour
{
	public TextMeshProUGUI winnerName;
	
	public void Initialize(Player winner)
	{
		winnerName.text = "Player"+ winner.ID+ "has won";
	}
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		SetupButtons();
	}
	
	private void SetupButtons()
	{
		TurnManager.instance.EndTurn();
	}
	
	public void Restart()
	{
		
	}
	
	public void Quit()
	{
		
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
