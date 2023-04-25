using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public bool playerTurn;
	public bool opponentTurn;
	public bool playerTurnEnded;
	public bool opponentTurnEnded;
	
    // Start is called before the first frame update
    void Start()
    {
	    opponentTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
	   
    }
    
	public void BeginRound()
	{
		playerTurnEnded = true;
	}
    
    
	
    
    
	
}



















