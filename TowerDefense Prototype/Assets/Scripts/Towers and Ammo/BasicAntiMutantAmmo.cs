using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAntiMutantAmmo : MonoBehaviour
{

	public float speed;
	public int Damage;
	public int TargetCount;

    private Transform player;
	public GameObject effect;
	
	//public Transform autoT;
	

	private void Update()
	{
		
		transform.position += transform.right * speed * Time.deltaTime;
		
		/*if(autoT != null)
		{
			if(Vector2.Distance(transform.position, autoT.position)<0.2f)
			{ 
				Instantiate(effect, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
		}*/
		
		
		Destroy(gameObject,5f);
	}
	
	

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Enemy"))
		{
			if(other.GetComponent<MediumMutant>())
			{
				other.GetComponent<MediumMutant>().health = other.GetComponent<MediumMutant>().health - Damage;
				Instantiate(effect, transform.position, Quaternion.identity);
				TargetCount++;
			}
			else if(other.GetComponent<BasicMutant>())
			{
				other.GetComponent<BasicMutant>().health = other.GetComponent<BasicMutant>().health - Damage;
				Instantiate(effect, transform.position, Quaternion.identity);
				TargetCount++;
			}
				
			
		}

		
		if(TargetCount >= 2)
		{
			Destroy(gameObject);
		}
		
		
	}
}
