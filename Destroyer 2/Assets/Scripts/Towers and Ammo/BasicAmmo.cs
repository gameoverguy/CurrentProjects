using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAmmo : MonoBehaviour
{
	//public AutoWeapon aw;
	
	public float speed;
	public int Damage;

    private Transform player;
	public GameObject effect;
	
	public Transform autoT;
	

	private void Start()
	{

	}

	private void Update()
	{
		
		transform.position += transform.right * speed * Time.deltaTime;
		
		if(autoT != null)
		{
			if(Vector2.Distance(transform.position, autoT.position)<0.2f)
			{ 
				Instantiate(effect, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
		}
		
		
		Destroy(gameObject,5f);
	}
	
	

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Enemy")){
			other.GetComponent<Enemy00>().health = other.GetComponent<Enemy00>().health - Damage;
			Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
