using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
	public List<SummonedCard> PlayerDeck =  new List<SummonedCard>();
	public List<SummonedCard> PlayerHand =  new List<SummonedCard>();
	public List<SummonedCard> PlayerArena =  new List<SummonedCard>();
	public List<SummonedCard> PlayerGraveyard = new List<SummonedCard>();
	
	public Transform[] PlayerHandSlots;
	public Transform[] PlayerArenaSlots;
	public Transform[] PlayerGraveyardSlots;
	
	public bool[] availablePlayerHandSlots;
	public bool[] availablePlayerArenaSlots;
	public bool[] availablePlayerGraveyardSlots;
	
	private GameManager GM;
	
	// Start is called before the first frame update
	void Start()
	{
		GM = FindObjectOfType<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
        
	}
    
    
	public void DrawCard()
	{
		if(PlayerDeck.Count >= 1 && GM.playerTurn == true)
		{
			SummonedCard randomCard = PlayerDeck[Random.Range(0,PlayerDeck.Count)];
			
			for (int i = 0; i < availablePlayerHandSlots.Length; i++)
			{
				if(availablePlayerHandSlots[i] == true)
				{
					randomCard.gameObject.SetActive(true);
					randomCard.inDeck = false;
					randomCard.inHand = true;
					randomCard.transform.position = PlayerHandSlots[i].transform.position;
					randomCard.CardPosition = i;
					availablePlayerHandSlots[i] = false;
					PlayerDeck.Remove(randomCard);
					PlayerHand.Add(randomCard);
					return;
				}
			}
		}
	}
	
	public void PlayCard(SummonedCard ClickedCard)
	{
		if(PlayerHand.Count >= 1 && GM.playerTurn == true)
		{
			for (int i = 0; i < availablePlayerArenaSlots.Length; i++)
			{
				if(availablePlayerArenaSlots[i] == true)
				{
					ClickedCard.Image.SetActive(true);
					ClickedCard.Icon.SetActive(false);
					ClickedCard.inHand = false;
					ClickedCard.inArena = true;
					availablePlayerHandSlots[ClickedCard.CardPosition] = true;
					ClickedCard.transform.position = PlayerArenaSlots[i].transform.position;
					ClickedCard.CardPosition = i;
					availablePlayerArenaSlots[i] = false;
					PlayerHand.Remove(ClickedCard);
					PlayerArena.Add(ClickedCard);
					return;
				}
			}
		}
	}
	
	public void CardToGraveyard(SummonedCard ClickedCard)
	{
		if(PlayerArena.Count >= 1)
		{
			for (int i = 0; i < availablePlayerGraveyardSlots.Length; i++)
			{
				if(availablePlayerGraveyardSlots[i] == true)
				{
					ClickedCard.Image.SetActive(false);
					ClickedCard.Icon.SetActive(true);
					ClickedCard.inArena = false;
					ClickedCard.inGraveyard = true;
					availablePlayerArenaSlots[ClickedCard.CardPosition] = true;
					ClickedCard.transform.position = PlayerGraveyardSlots[i].transform.position;
					availablePlayerGraveyardSlots[i] = false;
					PlayerArena.Remove(ClickedCard);
					PlayerGraveyard.Add(ClickedCard);
					return;
				}
			}
		}
	}
	
	public void CardBackToHand(SummonedCard ClickedCard)
	{
		if(PlayerArena.Count >= 1)
		{
			for (int i = 0; i < availablePlayerHandSlots.Length; i++)
			{
				if(availablePlayerHandSlots[i] == true)
				{
					ClickedCard.Image.SetActive(false);
					ClickedCard.Icon.SetActive(true);
					ClickedCard.inArena = false;
					ClickedCard.inHand = true;
					availablePlayerArenaSlots[ClickedCard.CardPosition] = true;
					ClickedCard.transform.position = PlayerHandSlots[i].transform.position;
					ClickedCard.CardPosition = i;
					availablePlayerHandSlots[i] = false;
					PlayerArena.Remove(ClickedCard);
					PlayerHand.Add(ClickedCard);
					return;
				}
			}
		}
	}
	
	
	
	
	
	
	
	
}



















