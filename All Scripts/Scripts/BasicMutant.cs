using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class BasicMutant : MonoBehaviour
{

	public int health;
	public GameObject deathEffect;
	public SpriteRenderer Sprite;

	public int creepReward;
	//public Cash cash;

	// Awake is called when the script instance is being loaded.
	private void Awake()
	{
		Enemies.enemies.Add(gameObject);
		//cash = FindObjectOfType<Cash>();
	}

	private void Start()
	{
		Sprite = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		
		if(health == 4)
		{
			Sprite.color = Color.yellow;
		}
		else if(health == 3)
		{
			Sprite.color = Color.green;
		}
		else if(health == 2)
		{
			Sprite.color = Color.blue;
		}
		else if(health == 1)
		{
			Sprite.color = Color.red;
		}
		else if(health <= 0)
		{ 
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Enemies.enemies.Remove(gameObject);
			//cash.CurrentCash = cash.CurrentCash + creepReward;
			Destroy(gameObject);	
		}
		
	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Target"))
		{
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
			//cash.currentReactorStr--;
		}
	}
}
