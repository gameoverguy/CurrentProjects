using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonedCard : MonoBehaviour
{
	[SerializeField]private int level;
	[SerializeField]private float attack;
	[SerializeField]private float health;
	public GameObject Icon;
	public GameObject Image;
	public int CardPosition;
	
	public bool inDeck;
	public bool inHand;
	public bool inArena;
	public bool inGraveyard;
	public bool isPlayer;
	public bool isOpponent;
	
	[SerializeField]private float hitdistance;
	
	[SerializeField]private LayerMask opponent;
	
	private PlayerManager PM;
	private OpponentManager OM;
	private GameManager GM;
	
    // Start is called before the first frame update
    void Start()
    {
	    PM = FindObjectOfType<PlayerManager>();
	    OM = FindObjectOfType<OpponentManager>();
	    GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
	{
		if(GM.playerTurnEnded || GM.opponentTurnEnded)
		{
			ExecutePlannedMove();
		}
	    
    }
    
	// OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
	private void OnMouseDown()
	{
		if(isPlayer)
		{
			if(inArena == true)
			{
				PM.CardBackToHand(this);
			}
			else
			{
				PM.PlayCard(this);
			}
		}
		
		
	}
	
	private void ExecutePlannedMove()
	{
		
		if(isPlayer && GM.playerTurn)
		{
			Vector2 direction = (OM.OpponentArenaSlots[CardPosition].position - transform.position).normalized;
			RaycastHit2D hit = Physics2D.Raycast(transform.position,direction,hitdistance,opponent);
			
			if(hit.collider != null)
			{
				Debug.Log(hit.transform.name);
				hit.collider.gameObject.GetComponent<SummonedCard>().takeDamage(attack);
			}
			
			GM.playerTurn = false;
			GM.playerTurnEnded = true;
			GM.opponentTurn = true;
		}
		
		if(isOpponent && GM.opponentTurn)
		{
			Vector2 direction = (PM.PlayerArenaSlots[CardPosition].position - transform.position).normalized;
			RaycastHit2D hit = Physics2D.Raycast(transform.position,direction,hitdistance,opponent);
			
			if(hit.collider != null)
			{
				Debug.Log(hit.transform.name);
				hit.collider.gameObject.GetComponent<SummonedCard>().takeDamage(attack);
			}
			
			GM.playerTurn = true;
			GM.playerTurnEnded = false;
			GM.opponentTurn = false;
			GM.opponentTurnEnded = true;
		}
		
		
	}
	
	public void takeDamage(float damage)
	{
		health = health - damage;
	}

	
}

















