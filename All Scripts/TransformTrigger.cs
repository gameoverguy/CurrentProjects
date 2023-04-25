using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TransformTrigger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
	{
	}

	
	private void OnTriggerExit(Collider collision)
	{
		if(collision.tag == "Player")
		{
			Debug.Log("test");
			Destroy(this.gameObject);
		}
	}
}














