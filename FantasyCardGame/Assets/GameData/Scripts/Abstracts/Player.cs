using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Player
{
	public int health, mana;
	public int ID;
	public bool myTurn;
	public List<CardController> AllCards = new List<CardController>();
	public List<CardController> Deck1 = new List<CardController>();
	public List<CardController> Deck2 = new List<CardController>();
	public List<CardController> Deck3 = new List<CardController>();
	public List<CardController> Deck4 = new List<CardController>();
	public List<CardController> Deck5 = new List<CardController>();
	
	public Player(int health, int ID, int mana)
	{
		this.health = health;
		this.ID = ID;
		this.mana = mana;
	}
}
