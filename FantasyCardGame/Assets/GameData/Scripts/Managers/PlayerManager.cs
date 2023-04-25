using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	public static PlayerManager instance;
	public List<Player> players = new List<Player>();
	
	// Awake is called when the script instance is being loaded.
	private void Awake()
	{
		instance = this;
	}
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	void Start()
	{
		UIManager.instance.UpdateValues(players[0],players[1]);
	}
	
	public void AssignTurn(int currentPlayerTurn)
	{
		foreach (Player player in players)
		{
			//player.myTurn = player.ID == currentPlayerTurn;
			
			if(currentPlayerTurn == player.ID)
			{
				player.myTurn = true;
			}
			else
			{
				player.myTurn = false;
			}
			
			if(player.myTurn)
			{
				player.mana = 5;
			}
		}
	}
	
	public void DamagePlayer(int ID, int Damage)
	{
		Player player = FindPlayerByID(ID);
		player.health -= Damage;
		if(player.health <= 0)
		{
			PlayerLost();
		}
	}
	
	public Player FindPlayerByID(int ID)
	{
		Player foundPlayer = null;
		
		foreach (Player player in players)
		{
			
			if(ID == player.ID)
			{
				foundPlayer = player;
			}

			//player.myTurn = player.ID == currentPlayerTurn;
			
			
		}
		
		return foundPlayer;
	}
	
	public void PlayerLost()
	{
		
	}
}






















