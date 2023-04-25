using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonedUnitAI : MonoBehaviour
{
	[SerializeField] private float Area = 15f;
	public GameObject SummonTarget;
	[SerializeField] private LayerMask Enemies;

	// the distance at which the player can attack
	public float attackDistance = 2f;

	// the amount of damage that the player's attack does
	public float attackDamage = 10f;

	// the time between attacks
	public float attackCooldown = 1f;

	// the time since the last attack
	private float lastAttackTime;
	
    // Start is called before the first frame update
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
	    DetectEnemies();
	    
	    if(SummonTarget != null)
	    {
	    	MoveToEnemy();
	    	AttackEnemy();
	    }
    }
    
	private void DetectEnemies()
	{
		Collider[] HitEnemy = Physics.OverlapSphere(transform.position,Area,Enemies);
		float closestDistance = Mathf.Infinity;
		
		foreach (Collider e in HitEnemy)
		{
			float distance = Vector3.Distance(transform.position, e.transform.position);
			
			if (distance < closestDistance)
			{
				closestDistance = distance;
				
				SummonTarget = e.gameObject;
			}
		}  
	}

    
	public void MoveToEnemy()
	{
		transform.LookAt (SummonTarget.transform.position);
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);

		if (Vector3.Distance (transform.position, SummonTarget.transform.position) > 2) 
		{
			transform.position = Vector3.MoveTowards(transform.position, SummonTarget.transform.position, 8f * Time.deltaTime);
		}
	}
	
	private void AttackEnemy()
	{
		// check if the player is within attack range
		float distanceToTarget = Vector3.Distance(transform.position, SummonTarget.transform.position);
		if (distanceToTarget < attackDistance)
		{
			// check if enough time has passed since the last attack
			if (Time.time - lastAttackTime >= attackCooldown)
			{
				// trigger the attack animation
				//GetComponent<Animator>().SetTrigger("Attack");

				// deal damage to the target
				//target.GetComponent<Health>().TakeDamage(attackDamage);

				// record the time of the last attack
				lastAttackTime = Time.time;
				
				Debug.Log("Attacked");
			}
		}
	}
	
	private void OnDrawGizmosSelected()
	{
		try
		{
			Gizmos.DrawWireSphere(transform.position, Area);
		}
			catch (System.Exception)
			{
				return;
			}
	}
}


























