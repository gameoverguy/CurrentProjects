using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
	public static TurnManager instance;
	public int currentPlayerTurn;
	public bool inBattle;
	
	private void Awake()
	{
		instance = this;
	}
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	private void Start()
	{
		StartTurnGamePlay(0);
	}
	
	public void StartTurnGamePlay(int playerID)
	{
		currentPlayerTurn = playerID;
		
		
		StartTurn();
	}
	
	public void StartTurn()
	{
		GamePlayUIController.instance.UpdateCurrentPlayerTurn(currentPlayerTurn);
		PlayerManager.instance.AssignTurn(currentPlayerTurn);
	}
	
	public void EndTurn()
	{
		currentPlayerTurn = currentPlayerTurn == 0 ? 1 : 0 ;
		inBattle = true;
		CardManager.instance.BattleTurn();
		
		
	}
	
	
}














