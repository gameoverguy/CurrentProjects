using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbofDestruction : MonoBehaviour
{
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		Vector3 playerInput = new Vector3((Input.GetAxisRaw("Horizontal")),(Input.GetAxisRaw("Vertical")), 0f);
		transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;
    }
}
