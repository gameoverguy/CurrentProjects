using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpponentManager : MonoBehaviour
{
	public List<SummonedCard> OpponentDeck =  new List<SummonedCard>();
	public List<SummonedCard> OpponentHand =  new List<SummonedCard>();
	public List<SummonedCard> OpponentArena =  new List<SummonedCard>();
	public List<SummonedCard> OpponentGraveyard = new List<SummonedCard>();
	
	public Transform[] OpponentHandSlots;
	public Transform[] OpponentArenaSlots;
	public Transform[] OpponentGraveyardSlots;
	
	public bool[] availableOpponentHandSlots;
	public bool[] availableOpponentArenaSlots;
	public bool[] availableOpponentGraveyardSlots;
	
	private bool CardDrawn;
	
	private GameManager GM;
	
	// Start is called before the first frame update
	void Start()
	{
		GM = FindObjectOfType<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		if(GM.opponentTurn)
		{
			DrawCard();
			
		}
		
		if(CardDrawn)
		{
			PlayCard();
		}
		
	}
    
    
	private void DrawCard()
	{
		if(OpponentDeck.Count >= 1)
		{
			SummonedCard randomCard = OpponentDeck[Random.Range(0,OpponentDeck.Count)];
			
			for (int i = 0; i < availableOpponentHandSlots.Length; i++)
			{
				if(availableOpponentHandSlots[i] == true)
				{
					randomCard.gameObject.SetActive(true);
					randomCard.inDeck = false;
					randomCard.inHand = true;
					randomCard.transform.position = OpponentHandSlots[i].transform.position;
					randomCard.CardPosition = i;
					availableOpponentHandSlots[i] = false;
					OpponentDeck.Remove(randomCard);
					OpponentHand.Add(randomCard);
					Debug.Log("test");
					return;
				}
			}
		}
		
		CardDrawn = true;
	}
	
	private void PlayCard()
	{
		if(OpponentHand.Count >= 1)
		{
			SummonedCard randomCard = OpponentHand[Random.Range(0,OpponentHand.Count)];
			
			for (int i = 0; i < availableOpponentArenaSlots.Length; i++)
			{
				if(availableOpponentArenaSlots[i] == true)
				{
					randomCard.Image.SetActive(true);
					randomCard.Icon.SetActive(false);
					randomCard.inHand = false;
					randomCard.inArena = true;
					availableOpponentHandSlots[randomCard.CardPosition] = true;
					randomCard.transform.position = OpponentArenaSlots[i].transform.position;
					randomCard.CardPosition = i;
					availableOpponentArenaSlots[i] = false;
					OpponentHand.Remove(randomCard);
					OpponentArena.Add(randomCard);
					return;
				}
			}
		}
	}
	
	private void CardToGraveyard(SummonedCard ClickedCard)
	{
		if(OpponentArena.Count >= 1)
		{
			for (int i = 0; i < availableOpponentGraveyardSlots.Length; i++)
			{
				if(availableOpponentGraveyardSlots[i] == true)
				{
					ClickedCard.Image.SetActive(false);
					ClickedCard.Icon.SetActive(true);
					ClickedCard.inArena = false;
					ClickedCard.inGraveyard = true;
					availableOpponentArenaSlots[ClickedCard.CardPosition] = true;
					ClickedCard.transform.position = OpponentGraveyardSlots[i].transform.position;
					availableOpponentGraveyardSlots[i] = false;
					OpponentArena.Remove(ClickedCard);
					OpponentGraveyard.Add(ClickedCard);
					return;
				}
			}
		}
	}
	

	
	
	
	
	
	
	
	
}



















