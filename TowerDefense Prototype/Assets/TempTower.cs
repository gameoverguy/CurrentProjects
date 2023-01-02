using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempTower : MonoBehaviour
{
	public bool tooClose;
    // Start is called before the first frame update
    void Start()
    {
	    tooClose = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("tower") || other.CompareTag("path"))
		{
			Debug.Log("enter");
			tooClose = true;
		}
	}
	
	// Sent when another object leaves a trigger collider attached to this object (2D physics only).
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("tower") || other.CompareTag("path"))
		{
			Debug.Log("exit");
			tooClose = false;
		}
	}
}
