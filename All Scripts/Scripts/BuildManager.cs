using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
	[SerializeField]private GameObject tower;
	[SerializeField]private GameObject BasicTower;
	private GameObject tempTower;
	public Vector3 mousePosition;
	public Vector3 worldPosition;
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{

	}
	
    // Start is called before the first frame update
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
	{
		worldPosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(worldPosition);
		mousePosition.z += Camera.main.nearClipPlane;
	    
		if(tempTower != null)
			tempTower.transform.position = mousePosition;
		
		if(Input.GetMouseButtonDown(0))
		{
			if(tempTower != null)
			{
				
				if(tempTower.GetComponent<TempTower>().tooClose == false)
				{
					Destroy(tempTower);
					Instantiate(BasicTower,mousePosition,Quaternion.identity);
				}
			}
			
		}
    }
    
	public void GetTower1()
	{
		tempTower = Instantiate(tower,mousePosition, Quaternion.identity);
	}
}
