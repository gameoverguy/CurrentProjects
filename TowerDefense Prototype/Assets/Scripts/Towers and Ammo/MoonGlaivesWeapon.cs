using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonGlaivesWeapon : MonoBehaviour
{
    public float rotSpeed;

	public GameObject projectile;
	public Transform spawnPos;
	public float timeBtwShots;
	public float startTimeBtwShots;
	
	public float _distance;
	public float Range;
	public GameObject Target = null;
	
	public GameObject tmpLightningPrefab;

	public bool enemyEngaged;
	
	private void Start()
	{
		Target = null;
		enemyEngaged = false;
	}

	private void Update()
	{
		
		UpdateNearestEnemy();		
		
		if(Target != null)
		{
			if(timeBtwShots <= 0)
			{
				tmpLightningPrefab = Instantiate(projectile, spawnPos.position, transform.rotation);
			
				tmpLightningPrefab.GetComponent<MoonGlaives>().LightningTarget = Target.transform;
				
				timeBtwShots = startTimeBtwShots;
			}
			else
			{
				timeBtwShots -= Time.deltaTime;
			}
		}	
	}
	
	
	
	public void UpdateNearestEnemy()
	{

		float distance = Mathf.Infinity;
        

		foreach (GameObject enemy in Enemies.enemies)
		{
			if(enemy != null)
			_distance = (transform.position - enemy.transform.position).magnitude;

			if (_distance < distance)
			{
				distance = _distance;
			}
			
			if(enemyEngaged == false)
			{							
				if (distance <= Range)
				{

					Target = enemy;					
					enemyEngaged = true;
				}
				else
				{
					Target = null;				
				}		
			}
			
			if(distance >= Range)
			{
				Target = null;
				enemyEngaged = false;
			}
			
			if(Target == null)
			{
				enemyEngaged = false;
			}
			
		} 
	}
	
	void OnDrawGizmosSelected()
	{
		if (Target != null)
		{
			// Draws a blue line from this transform to the target
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(transform.position, Target.gameObject.transform.position);
		}
		
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position,Range);
		
	}
}
