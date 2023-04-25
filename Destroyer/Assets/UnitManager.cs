using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
	[SerializeField] private Transform[] SpawnPoints;
	[SerializeField] private GameObject basicEnemy;
	[SerializeField] private GameObject mediumEnemy;
	[SerializeField] private GameObject largeEnemy;
	
	public int TotalEnemyPool;
	[SerializeField] private int basicEnemyPool;
	[SerializeField] private int mediumEnemyPool;
	[SerializeField] private int largeEnemyPool;
	
    // Start is called before the first frame update
    void Start()
	{
		basicEnemyPool = 50;
		mediumEnemyPool = 20;
		largeEnemyPool = 5;
		TotalEnemyPool = basicEnemyPool + mediumEnemyPool + largeEnemyPool;
	    StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
	    TotalEnemyPool = basicEnemyPool + mediumEnemyPool + largeEnemyPool;
    }
    
	private void SpawnBasicEnemies()
	{
		int random = Random.Range(0,4);
		Instantiate(basicEnemy,SpawnPoints[random].position,Quaternion.identity);
		basicEnemyPool--;
	}
	
	private void SpawnMediumEnemies()
	{
		int random = Random.Range(0,4);
		Instantiate(mediumEnemy,SpawnPoints[random].position,Quaternion.identity);
		mediumEnemyPool--;
	}
	
	private void SpawnLargeEnemies()
	{
		int random = Random.Range(0,4);
		Instantiate(largeEnemy,SpawnPoints[random].position,Quaternion.identity);
		largeEnemyPool--;
	}
	
	IEnumerator EnemySpawner()
	{
		while(true)
		{
			if(basicEnemyPool > 0)
			{
				SpawnBasicEnemies();
			}
			
			if(basicEnemyPool <= 0 && mediumEnemyPool > 0)
			{
				SpawnMediumEnemies();
			}
			
			if(basicEnemyPool <= 0 && mediumEnemyPool <= 0 && largeEnemyPool > 0)
			{
				SpawnLargeEnemies();
			}
			
			yield return new WaitForSeconds(1);
		}

	}
}
