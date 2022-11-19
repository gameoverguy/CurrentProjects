using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Enemy00 : MonoBehaviour
{
	
    private Animator anim;
	public float minAnimSpeed;
	public float maxAnimSpeed;

	public int health;
	public GameObject deathEffect;

	public bool isHit;
	public int creepReward;
	public Cash cash;

	// Awake is called when the script instance is being loaded.
	private void Awake()
	{
		Enemies.enemies.Add(gameObject);
		cash = FindObjectOfType<Cash>();
	}

	private void Start()
	{
		anim = GetComponent<Animator>();
		anim.speed = Random.Range(minAnimSpeed, maxAnimSpeed);
		
		isHit = false;
	}

	private void Update()
	{
		if(health <= 0)
		{ 
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Enemies.enemies.Remove(gameObject);
			cash.CurrentCash = cash.CurrentCash + creepReward;
			Destroy(gameObject);	
		}
	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Target"))
		{
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
			cash.currentReactorStr--;
		}
	}
}
