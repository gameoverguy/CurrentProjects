using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private int playerSpeed;
	[SerializeField] private GameObject duplicate;
	[SerializeField] private Transform Spawnpoint;
	[SerializeField] private Transform SummoningPoint_1;
	[SerializeField] private Transform SummoningPoint_2;
	
	[SerializeField] private GameObject SummonedUnit01;
	[SerializeField] private GameObject SummonedUnit02;
	
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
	{
		Movement();
		//RotateOrbs();
	}
    
	private void Movement()
	{
		Vector2 inputVector = new Vector2(0,0);
		
		if(Input.GetKey(KeyCode.A))
		{
			inputVector.x = -1;
		}
		if(Input.GetKey(KeyCode.D))
		{
			inputVector.x = +1;
		}
		if(Input.GetKey(KeyCode.W))
		{
			inputVector.y = +1;
		}
		if(Input.GetKey(KeyCode.S))
		{
			inputVector.y = -1;
		}
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			SummonUnits();
		}
		
		inputVector = inputVector.normalized;
		Vector3 movDir = new Vector3(inputVector.x,0f,inputVector.y);
		
		
		transform.position += movDir * playerSpeed * Time.deltaTime;
	}
	
	private void SummonUnits()
	{
		Instantiate(SummonedUnit01,SummoningPoint_1.position,Quaternion.identity);
		Instantiate(SummonedUnit02,SummoningPoint_2.position,Quaternion.identity);
	}
	
	// OnTriggerEnter is called when the Collider other enters the trigger.
	private void OnTriggerEnter(Collider collision)
	{
		if(collision.tag == "Transform")
		{
			Destroy(collision.gameObject);
			//Multiply();
		}
	}
	
	private void RotateOrbs()
	{
		Spawnpoint.Rotate(new Vector3(0, 30f, 0) * Time.deltaTime);
	}

	
}


















