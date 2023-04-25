using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
	public CardController targetCard = null;
	public List<CardController> targetCards = new List<CardController>();
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void FindOppositeTarget(GameObject parent)
	{
		if(CardManager.instance.player0PlayArea.Count > 0 && CardManager.instance.player1PlayArea.Count > 0)
		{
			if(PlayerManager.instance.players[0].myTurn == true)
			{
				CardController thiscard = parent.GetComponent<CardController>();
				int thiscardposition = CardManager.instance.player0PlayArea.IndexOf(thiscard);
				int targetcardpostion = thiscardposition;
				targetCard = CardManager.instance.player1PlayArea[targetcardpostion];
				Debug.Log(thiscardposition);
			}
		}
	}
	
	public void FindRandomTarget(GameObject parent)
	{
		if(CardManager.instance.player0PlayArea.Count > 0 && CardManager.instance.player1PlayArea.Count > 0)
		{
			if(PlayerManager.instance.players[0].myTurn == true)
			{
				int randomNumber = Random.Range(0,4);
				int targetcardpostion = randomNumber;
				targetCard = CardManager.instance.player1PlayArea[targetcardpostion];
			}
		}
	}
	
	public void FindAllTargets(GameObject parent)
	{
		if(CardManager.instance.player0PlayArea.Count > 0 && CardManager.instance.player1PlayArea.Count > 0)
		{
			if(PlayerManager.instance.players[0].myTurn == true)
			{
				targetCards.AddRange(CardManager.instance.player1PlayArea);
			}
			
			if(PlayerManager.instance.players[1].myTurn == true)
			{
				targetCards.AddRange(CardManager.instance.player0PlayArea);
			}
		}
	}
	
	/*
	public void FindRandomTwoTargets()
	{
		int randomNumber;
		int lastNumber;
		int maxAttempts = 10;

		for(int i=0; randomNumber == lastNumber && i < maxAttempts; i++)
		{
			randomNumber = Random.Range(0, 10);
		}
		
		lastNumber = randomNumber;

	}
	*/
	
	
}
















