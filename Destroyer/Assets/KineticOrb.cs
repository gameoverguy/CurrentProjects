using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticOrb : MonoBehaviour
{
	[SerializeField] private GameObject KineticAmmo;
	[SerializeField] private float Area = 8f;
	
	public GameObject KineticOrbTarget;
	[SerializeField] private LayerMask Enemies;
	
    // Start is called before the first frame update
    void Start()
    {
	    StartCoroutine(KineticAmmoSpawner());
    }

    // Update is called once per frame
    void Update()
    {
	    DetectEnemy();
	    
	    /*
	    if(KineticOrbTarget)
	    {
	    	
	    }
	    else
	    {
	    	StopCoroutine(KineticAmmoSpawner());
	    }
	    */
    }
    
	private void DetectEnemy()
	{
		Collider[] HitEnemy = Physics.OverlapSphere(transform.position,Area,Enemies);
		float closestDistance = Mathf.Infinity;

		foreach (Collider e in HitEnemy)
		{
			float distance = Vector3.Distance(transform.position, e.transform.position);
			
			if (distance < closestDistance)
			{
				closestDistance = distance;
				KineticOrbTarget = e.gameObject;
			}
			
			if(distance > Area)
			{
				KineticOrbTarget = null;
			}
		}

	}
    
	private void CreateKineticAmmo()
	{
		GameObject tempammo = Instantiate(KineticAmmo,transform.position,Quaternion.identity);
		tempammo.GetComponent<KineticOrbAmmo>().KineticOrbAmmoTarget = KineticOrbTarget.transform;
	}
	

	
	IEnumerator KineticAmmoSpawner()
	{
		while(true)
		{
			if(KineticOrbTarget)
			{
				CreateKineticAmmo();
			}
			
			yield return new WaitForSeconds(1f);
		}
	}
}
