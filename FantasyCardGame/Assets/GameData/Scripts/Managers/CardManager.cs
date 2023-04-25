using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
	public static CardManager instance;
	public List<Card> player0Deck1 = new List<Card>();
	public List<Card> player1Deck1 = new List<Card>();
	
	public List<CardController> player0PlayArea = new List<CardController>(); 
	public List<CardController> player1PlayArea = new List<CardController>();
	
	public Transform player1Hand, player2Hand;
	public CardController cardControllerPrefab;
	
	
	private void Awake()
	{
		instance = this;
	}
	
	private void Start()
	{
		GenerateCard();
	}
	
	private void GenerateCard()
	{
		foreach (Card card in player0Deck1)
		{
			CardController newCard = Instantiate(cardControllerPrefab,player1Hand);
			newCard.Initialize(card);

		}
		
		foreach (Card card in player1Deck1)
		{
			CardController newCard = Instantiate(cardControllerPrefab,player2Hand);
			newCard.Initialize(card);
		}
		

	}
	
	
	
	public void BattleTurn()
	{
		MarkAsPlayed();
		Attack();
		TurnManager.instance.StartTurn();
	}
	
	public void MarkAsPlayed()
	{
		foreach (CardController cardcontroller in player0PlayArea)
		{
			cardcontroller.card.isPlayed = true;
		}
		
		foreach (CardController cardcontroller in player1PlayArea)
		{
			cardcontroller.card.isPlayed = true;
		}
	}
	

	
	public void Attack()
	{
		if(PlayerManager.instance.players[0].myTurn == true)
		{
			foreach (CardController cardcontroller in player0PlayArea)
			{
				if(cardcontroller.card.ability.Length > 0)
				{
					cardcontroller.card.ability[0].Activate(cardcontroller.gameObject);
				}
			}
		}
		
		if(PlayerManager.instance.players[1].myTurn == true)
		{
			foreach (CardController cardcontroller in player1PlayArea)
			{
				if(cardcontroller.card.ability.Length > 0)
				{
					cardcontroller.card.ability[0].Activate(cardcontroller.gameObject);
				}
			}
		}
		
		
		
		
		/*
		if(player0PlayArea.Count > 0 && player1PlayArea.Count > 0)
		{
			if(PlayerManager.instance.players[0].myTurn == true)
			{
				if(player0PlayArea.Count > 0 && player1PlayArea.Count > 0)
				{
					//player0PlayArea[0].card.ability[0].Activate(player0PlayArea,player1PlayArea);
					player1PlayArea[0].card.health -= player0PlayArea[0].card.attack;
					
				}
					
				
				if(player0PlayArea.Count > 1 && player1PlayArea.Count > 1)
					player1PlayArea[1].card.health -= player0PlayArea[1].card.attack;
				
				if(player0PlayArea.Count > 2 && player1PlayArea.Count > 2)
					player1PlayArea[2].card.health -= player0PlayArea[2].card.attack;
				
				if(player0PlayArea.Count > 3 && player1PlayArea.Count > 3)
					player1PlayArea[3].card.health -= player0PlayArea[3].card.attack;
				
				if(player0PlayArea.Count > 4 && player1PlayArea.Count > 4)
					player1PlayArea[4].card.health -= player0PlayArea[4].card.attack;
				
			}
			
			if(PlayerManager.instance.players[1].myTurn == true)
			{
				if(player0PlayArea.Count > 0 && player1PlayArea.Count > 0)
				{
					//player1PlayArea[0].card.ability[0].Activate(player0PlayArea,player1PlayArea);
					player0PlayArea[0].card.health -= player0PlayArea[1].card.attack;
					
				}
					
				
				if(player0PlayArea.Count > 1 && player1PlayArea.Count > 1)
					player0PlayArea[1].card.health -= player1PlayArea[1].card.attack;
				
				if(player0PlayArea.Count > 2 && player1PlayArea.Count > 2)
					player0PlayArea[2].card.health -= player1PlayArea[2].card.attack;
				
				if(player0PlayArea.Count > 3 && player1PlayArea.Count > 3)
					player0PlayArea[3].card.health -= player1PlayArea[3].card.attack;
				
				if(player0PlayArea.Count > 4 && player1PlayArea.Count > 4)
					player0PlayArea[4].card.health -= player1PlayArea[4].card.attack;
				
			}
			
		}
		
		
		
		int player0CardPosition = 0, player1CardPosition = 0;
		
		if(card.isPlayed && card.ownerID == 0)
		{
			player0CardPosition = CardManager.instance.player0PlayArea.IndexOf(this);
			
			if(CardManager.instance.player1PlayArea.Count > 0)
			{
				CardManager.instance.player1PlayArea[player1CardPosition].card.health -= card.attack;
			}
			else
			{
				return;
			}
				
		}
		
		if(card.isPlayed && card.ownerID == 1)
		{
			
			player1CardPosition = CardManager.instance.player1PlayArea.IndexOf(this);
			
			if(CardManager.instance.player0PlayArea[player0CardPosition] != null)
			{
			CardManager.instance.player0PlayArea[player0CardPosition].card.health -= card.attack;
			}
			else
			{
			return;
			}
			
			Debug.Log(player1CardPosition);
			
		}*/
		
		
	}
}

















