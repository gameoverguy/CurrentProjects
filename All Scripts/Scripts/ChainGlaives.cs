using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChainGlaives : MonoBehaviour
{
	[SerializeField] private LayerMask layermask;
	public List<Transform> targets = new List<Transform>();
	public bool isHit = false;
	public int targetIndex;
	public Transform LightningTarget;
	public int GlaiveDamage;
	public GameObject effect;
	
	public float speed;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Enemy"))
		{
			isHit = true;
			collision.GetComponent<Enemy00>().health = collision.GetComponent<Enemy00>().health - GlaiveDamage;
			Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
		
		if(isHit && collision.tag == "Enemy" && collision.transform == LightningTarget)
		{
			
			//isHit = true;
			targets.Clear();
			
			Collider2D[] tmpcol = Physics2D.OverlapCircleAll(collision.transform.position,10,layermask);
			
			foreach(Collider2D collider in tmpcol)
			{
				if(collider.transform != LightningTarget && collider.transform != transform && collider.tag == "Enemy")
				{
					targets.Add(collider.transform);
				}
				
			}
			
			PickTarget(collision);
			
			
			
		}
		
		if(targets.Count != 0)
		{
			if(LightningTarget == targets[targets.Count -1])
			{
				//Destroy(this.gameObject);
			}
		}
		
		
		
	}
	
	private void PickTarget(Collider2D collision)
	{
		if(targets.Count != 0)
			LightningTarget = targets[0];
		
		//targetIndex++;
		
		
	}
		

	private void Update()
	{
		float distance = 0;
		
		if(LightningTarget != null)
		{
			isHit = false;
			transform.position = Vector2.MoveTowards(transform.position, LightningTarget.position, speed * Time.deltaTime);
			distance = Vector2.Distance(transform.position, LightningTarget.position);
		}
		else
		{
			
			Destroy(gameObject);
		}
		
		/*if(distance <= 0.1f)
		{
			if(isHit && targetIndex < targets.Count && LightningTarget != null && targets.Count != 0)
			{
				PickTarget(LightningTarget.GetComponent<Collider2D>());
			}

		}*/
		
	}
	
	
}
