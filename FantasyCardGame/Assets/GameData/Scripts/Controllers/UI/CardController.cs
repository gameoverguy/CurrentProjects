using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using Unity.Netcode;

public class CardController : NetworkBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
	public Card card;
	public Image illustration, image;
	public TextMeshProUGUI cardName, attack, health, manaCost;
	[SerializeField]private Transform originalParent;
	public int slotPosition;
	
	private void Awake()
	{
		image = GetComponent<Image>();
	}
    void Start()
    {
	    if(!IsOwner) return;
    }
    
	public void Initialize(Card card)
	{
		this.card = card;
		illustration.sprite = card.illustration;
		cardName.text = card.cardName;
		attack.text = card.attack.ToString();
		health.text = card.health.ToString();
		manaCost.text = card.manaCost.ToString();
		originalParent = transform.parent;
	}

    void Update()
	{
		if(!IsOwner) return;
	    attack.text = card.attack.ToString();
		health.text = card.health.ToString();
    }
    
	
	//Detect current clicks on the GameObject (the one with the script attached)
	public void OnPointerDown(PointerEventData pointerEventData)
	{
		
		if(card.isPlayed || TurnManager.instance.currentPlayerTurn != card.ownerID)
		{
			
		}
		else
		{
			image.raycastTarget = false;
			transform.SetParent(transform.root);
		}
		
	}

	//Detect if clicks are no longer registering
	public void OnPointerUp(PointerEventData pointerEventData)
	{
		if(card.isPlayed || TurnManager.instance.currentPlayerTurn != card.ownerID)
		{
			
		}
		else
		{
			image.raycastTarget = true;
			AnalyzePointerUp(pointerEventData);
		}
	}
	
	
	
	private void AnalyzePointerUp(PointerEventData pointerEventData)
	{
		if(pointerEventData.pointerEnter != null)
		{
			if(pointerEventData.pointerEnter.name == $"Player{card.ownerID + 1}PlayArea")
			{
				if(PlayerManager.instance.FindPlayerByID(card.ownerID).mana >= card.manaCost)
				{
					PlayCard(pointerEventData.pointerEnter.transform);
				}
				else
				{
					ReturnToCurrentParent();
				}
			}
			else if(pointerEventData.pointerEnter.name == $"Player{card.ownerID + 1}Hand")
			{
				RetractCard(pointerEventData.pointerEnter.transform);
			}
			else
			{
				ReturnToCurrentParent();
			}
		}
	}
	
	private void PlayCard(Transform playArea)
	{
		transform.SetParent(playArea);
		transform.localPosition = Vector3.zero;
		originalParent = playArea;
		
		if(card.ownerID == 0)
		{
			if(!CardManager.instance.player0PlayArea.Contains(this))
			{
				CardManager.instance.player0PlayArea.Add(this);
				PlayerManager.instance.FindPlayerByID(card.ownerID).mana -= card.manaCost;
			}
		}
		
		if(card.ownerID == 1)
		{
			if(!CardManager.instance.player1PlayArea.Contains(this))
			{
				CardManager.instance.player1PlayArea.Add(this);
				PlayerManager.instance.FindPlayerByID(card.ownerID).mana -= card.manaCost;
			}
		}
	}
	
	private void RetractCard(Transform handArea)
	{
		transform.SetParent(handArea);
		transform.localPosition = Vector3.zero;
		originalParent = handArea;
		
		if(card.ownerID == 0)
		{
			if(CardManager.instance.player0PlayArea.Contains(this))
			{
				CardManager.instance.player0PlayArea.Remove(this);
				PlayerManager.instance.FindPlayerByID(card.ownerID).mana += card.manaCost;
			}
		}
		else
		{
			if(CardManager.instance.player1PlayArea.Contains(this))
			{
				CardManager.instance.player1PlayArea.Remove(this);
				PlayerManager.instance.FindPlayerByID(card.ownerID).mana += card.manaCost;
			}
		}
		
		
	}
	
	private void ReturnToCurrentParent()
	{
		transform.SetParent(originalParent);
	}
	
	
	public void OnDrag(PointerEventData pointerEventData)
	{
		if(transform.parent == originalParent)
		{
			return;
		}
		transform.position = pointerEventData.position;
	}

	/*
	public void ActivateAttack()
	{
		if(card.ability.Length > 0)
		{
			card.ability[0].Activate(gameObject);
		}
	}
	*/
}














