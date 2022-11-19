using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using Pathfinding;

public class UserTaps : MonoBehaviour
{
	public int tapTimes;
	public float restTimer;
	public bool isHoldingDown;
	public RaycastHit2D hit;
	
	public GameObject Block;
	public GameObject Drone;
	public GameObject MoonGlaiveTower;
	public GameObject TempTower;
	
	public GameObject TowerPanel;
	public GameObject BlockPanel;
	public GameObject ConfirmPanel;
	public GameObject DestroyPanel;
	public GameObject BlockDestroyPanel;
	
	public Transform hitbase;
	public Cash cash;
	public int droneCost = 50;
	
	public Transform Tgt;
	public Transform begin;
	
	public AstarPath astar;
	
	public WaveGenerator wavegen;

	// Update is called once per frame
    
	IEnumerator ResetTapTimes(){
		yield return new WaitForSeconds(restTimer);
		tapTimes = 0;
	}
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		wavegen = FindObjectOfType<WaveGenerator>();
		astar = FindObjectOfType<AstarPath>();
		cash = FindObjectOfType<Cash>();
		
	}
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	void Start()
	{
		TowerPanel.SetActive(false);
		
	}
	
    void Update()
	{
		hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		
		
		

		if(Input.GetKeyDown(KeyCode.Mouse0) && !isMouseOverUI())
		{
			
			
			if(hit.collider != null)
			{
				//Debug.Log(hit.collider.name);
				
				if(hit.collider.CompareTag("Base"))
				{
					BlockDestroyPanel.SetActive(true);
					//TowerPanel.active = true;
					DestroyPanel.SetActive(false);
					ConfirmPanel.SetActive(false);
					hitbase = hit.transform;
				}
				else
				{
					BlockDestroyPanel.SetActive(false);
				}
				
				if(hit.collider.CompareTag("Tower"))
				{
					DestroyPanel.SetActive(true);
					hitbase = hit.transform;
				}
				else
				{
					DestroyPanel.SetActive(false);
				}
				
				if(hit.collider.CompareTag("Empty"))
				{
					BlockPanel.SetActive(true);
					hitbase = hit.transform;
					TowerPanel.SetActive(false);
				}
				else
				{
					BlockPanel.SetActive(false);
				}

				
				StartCoroutine("ResetTapTimes");
				tapTimes++;
			}
			else
			{
				TowerPanel.SetActive(false);
				BlockPanel.SetActive(false);
				ConfirmPanel.SetActive(false);
				DestroyPanel.SetActive(false);
				BlockDestroyPanel.SetActive(false);
			}
			
	    }
	    
	    if(tapTimes >= 2)
	    {

	    	tapTimes = 0;
	    	//confirm action
	    	
	    	
	    	
	    	
	    	
	    }
	}
	
	private bool isMouseOverUI()
	{
		return EventSystem.current.IsPointerOverGameObject();
	}
	
	public void BuildBlock()
	{
		
			if(wavegen.state == WaveGenerator.SpawnState.COUNTING)
			{
				GameObject tempb = Instantiate(Block, hitbase.position,Quaternion.identity);
				astar.Scan();
				
				GraphNode node1 = AstarPath.active.GetNearest(begin.position , NNConstraint.Default).node;
				GraphNode node2 = AstarPath.active.GetNearest(Tgt.position, NNConstraint.Default).node;
				
				if (PathUtilities.IsPathPossible(node1, node2))
				{
					Debug.Log("yes");
				}
				else
				{
					Destroy(tempb);
					astar.Scan();
				}
				BlockPanel.SetActive(false);
			
			}
			else
			{
				return;
			}
		
		
	}
    
	public void BuildDrone()
	{

		if(cash.CurrentCash >= droneCost && hitbase != null)
		{
			TempTower = Instantiate(Drone, new Vector3(hitbase.position.x, hitbase.position.y, hitbase.position.z - 1f),Quaternion.identity);
			cash.CurrentCash = cash.CurrentCash - droneCost;
			TowerPanel.SetActive(false);
		}
		else
		{
		return;
		}
		
	}
	
	public void BuildMoonGlaiveTower()
	{

		if(cash.CurrentCash >= droneCost && hitbase != null)
		{
			TempTower = Instantiate(MoonGlaiveTower, new Vector3(hitbase.position.x, hitbase.position.y, hitbase.position.z - 1f),Quaternion.identity);
			cash.CurrentCash = cash.CurrentCash - droneCost;
			TowerPanel.SetActive(false);
		}
		else
		{
			return;
		}
		
	}
	
	public void UpgradeTower()
	{
		if(cash.CurrentCash >= droneCost && hitbase.GetComponent<BasicTower>().currentLevel < hitbase.GetComponent<BasicTower>().MaxLevel)
		{
			hitbase.GetComponent<BasicTower>().currentLevel++;
			cash.CurrentCash = cash.CurrentCash - droneCost;
		}
		
	}
	
	
	public void CancelDrone()
	{
		Destroy(TempTower);
		ConfirmPanel.SetActive(false);
		TowerPanel.SetActive(true);
	}
	
	public void CancelDestroy()
	{
		BlockDestroyPanel.SetActive(false);
	}
	
	public void DestroyDrone()
	{
		Destroy(hitbase.gameObject);
		BlockDestroyPanel.SetActive(false);
		cash.CurrentCash = cash.CurrentCash + droneCost;
	}
	
	public void CancelDestroyBlock()
	{
		DestroyPanel.SetActive(false);
	}
	
	public void BuildNewTower()
	{
		BlockDestroyPanel.SetActive(false);
		TowerPanel.SetActive(true);
		
		//DestroyPanel.SetActive(false);
		//cash.CurrentCash = cash.CurrentCash + droneCost;
	}
	
	public void Destroyblock()
	{
		if(hitbase.GetComponent<Collider2D>().CompareTag("Base") && wavegen.state == WaveGenerator.SpawnState.COUNTING)
		{
			Destroy(hitbase.gameObject);
			astar.Scan();
			BlockDestroyPanel.SetActive(false);
		}
		
		
		//cash.CurrentCash = cash.CurrentCash + droneCost;
	}

	
}
