using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticOrbAmmo : MonoBehaviour
{
	public Transform KineticOrbAmmoTarget;
	[SerializeField] private Transform tempTarget;
	[SerializeField] private float Speed;
    // Start is called before the first frame update
    void Start()
    {
	    tempTarget = KineticOrbAmmoTarget;
    }

    // Update is called once per frame
    void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, tempTarget.position, Speed * Time.deltaTime);
	}
    
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			Destroy(col.gameObject);
			Enemies.enemies.Remove(col.gameObject);
			Destroy(gameObject);
		}
	}
    
}
