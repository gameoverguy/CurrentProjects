using UnityEngine;
using System.Collections;
using Pathfinding;

public class WaveGenerator : MonoBehaviour
{

	public enum SpawnState { SPAWNING, WAITING, COUNTING, FINISHED };

	[System.Serializable]
	public class Wave
	{
		public string name;
		
		public int count;
		public float rate;
	}

	public Transform[] enemy;
	public Wave[] waves;
	private int nextWave = 0;
	public bool goNextWave;
	
	public AstarPath astar;
	
	public GameObject success;
	
	public Cash cash;
	
	private Seeker seeker;
	
	public LineRenderer lr;
	
	public int NextWave
	{
		get { return nextWave + 1; }
	}

	public Transform[] spawnPoints;

	public float timeBetweenWaves;
	private float waveCountdown;

	public float WaveCountdown
	{
		get { return waveCountdown; }
	}

	private float searchCountdown = 0.5f;

	public SpawnState state = SpawnState.COUNTING;

	public SpawnState State
	{
		get { return state; }
	}
	
	void Awake()
	{
		astar = FindObjectOfType<AstarPath>();
		cash = FindObjectOfType<Cash>();
	}

	void Start()
	{
		Time.timeScale = 1;
		success.SetActive(false);
		waveCountdown = timeBetweenWaves;
		goNextWave = false;
		cash.TotalWaves = waves.Length;
		lr = GetComponent<LineRenderer>();
	}
	
	public void NextWaveButton()
	{
		//astar.Scan();
		
		if(state == SpawnState.COUNTING)
		{
			cash.currentWave++;
			goNextWave = true;
		}
	}

	void Update()
	{
		if(state == SpawnState.COUNTING)
		{
			lr.enabled = true;
		}
		else
		{
			lr.enabled = false;
		}
		
		if (state == SpawnState.FINISHED)
		{ 
			Time.timeScale = 0;
			success.SetActive(true);
		}


		if (state == SpawnState.WAITING)
		{
			if (!EnemyIsAlive())
			{
				WaveCompleted();
			}
			else
			{
				return;
			}
		}

		if (waveCountdown <= 0 && goNextWave)
		{
			if (state != SpawnState.SPAWNING)
			{
				StartCoroutine(SpawnWave(waves[nextWave]));
				goNextWave = false;
			}
		}
		else
		{
			waveCountdown -= Time.deltaTime;
		}
	}

	void WaveCompleted()
	{

		state = SpawnState.COUNTING;
		waveCountdown = timeBetweenWaves;

		if (nextWave +1> waves.Length-1)
		{
			state = SpawnState.FINISHED;
		}
		
		else
		{
			nextWave++;
		}
	}

	bool EnemyIsAlive()
	{
		searchCountdown -= Time.deltaTime;
		if (searchCountdown <= 0f)
		{
			searchCountdown = 0.5f;
			if ( Enemies.enemies.Count == 0 || GameObject.FindGameObjectWithTag("Enemy") == null)
			{
				return false;
			}
		}
		return true;
	}

	IEnumerator SpawnWave(Wave _wave)
	{
		state = SpawnState.SPAWNING;

		for (int i = 0; i < _wave.count; i++)
		{

            SpawnEnemy(enemy[Random.Range(0, enemy.Length)]);
			yield return new WaitForSeconds(1f / _wave.rate);
		}

		state = SpawnState.WAITING;

		yield break;
	}

	void SpawnEnemy(Transform _enemy)
	{
		Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
		Instantiate(_enemy, _sp.position, _sp.rotation);
	}

	public void StartWave()
    {
		gameObject.GetComponent<WaveGenerator>().enabled = true;
    }

}
