using UnityEngine;

[System.Serializable]
public class Card
{
	public Sprite illustration; 
	public string cardName;
	public int attack,health,manaCost,ownerID,uniqueID;
	public bool isPlayed;
	public Ability[] ability;
}
