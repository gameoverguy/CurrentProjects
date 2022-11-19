using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLaserWeapon : MonoBehaviour
{
    public float rotSpeed;

	public GameObject projectile;
	public Transform spawnPos;
	public float timeBtwShots;
	public float startTimeBtwShots;
	
	public float timeBtwLasers;
	public float startTimeBtwLasers;
	public int Damage;
	
	public float _distance;
	public float Range;
	public Transform Target;
	public LayerMask Hit;
	
	public bool enemyEngaged;
	
	//public GameObject tmpLightningPrefab;
	public LineRenderer lr;
	
	private void Start()
	{
		Target = null;
		lr = GetComponent<LineRenderer>();
	}

	private void Update()
	{
		
		DetectEnemy();
		
		if(timeBtwShots <= 0)
		{
			
			if(Target != null)
			{
				lr.enabled = true;
				lr.positionCount = 2;
				lr.SetPosition(0, transform.position);
				lr.SetPosition(1, Target.position);
				Target.GetComponent<Enemy00>().health = Target.GetComponent<Enemy00>().health - Damage;
			}
			
			timeBtwShots = startTimeBtwShots;
			
		}
		else
		{
			lr.enabled = false;
			timeBtwShots -= Time.deltaTime;
			
		}
			
		
	}
	
	public void DetectEnemy()
	{
		//Collider2D[] enemycolliders = Physics2D.OverlapCircleAll(transform.position,Range,Hit);
		
		Collider2D enemycoll = Physics2D.OverlapCircle(transform.position,Range,Hit);
		
		if(enemycoll != null)
		Target = enemycoll.transform;
		
	}
	
	
	
	void OnDrawGizmosSelected()
	{
		if (Target != null)
		{
			// Draws a blue line from this transform to the target
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(transform.position, Target.position);
		}
		
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position,Range);
		
	}
}
