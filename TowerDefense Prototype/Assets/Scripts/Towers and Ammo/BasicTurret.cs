using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTurret : MonoBehaviour
{
    public float rotSpeed;

	public GameObject projectile;
	public Transform spawnPos;
	public float timeBtwShots;
	public float startTimeBtwShots;
	
	public float _distance;
	public float Range;
	public GameObject Target = null;
	public Transform pivot;
	
	public GameObject tmpPrefab;
	
	
	public bool enemyEngaged;
	
	private void Awake()
	{
		//cl = FindObjectOfType<ChainLightningSystem>();
	}
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
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
			
			Vector2 relative = Target.transform.position - pivot.position;
			float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg;
			
			Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			pivot.localRotation = Quaternion.Slerp(transform.rotation, rotation, rotSpeed * Time.deltaTime);
			
			
			if(timeBtwShots <= 0)
			{
				tmpPrefab = Instantiate(projectile, spawnPos.position, transform.rotation);
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
