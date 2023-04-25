using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitAI : MonoBehaviour
{
	[SerializeField] private float Area = 10f;
	[SerializeField] private float Speed;
	
	public GameObject EnemyTarget;
	[SerializeField] private LayerMask Player;
	
	[SerializeField] private Animator EnemyAnimator;
	
	private Vector3 moveDirection;
	
    // Start is called before the first frame update
    void Start()
    {
	    Idle();
    }

    // Update is called once per frame
    void Update()
	{
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);
		
		DetectEnemies();

	    if(EnemyTarget != null)
	    {
	    	MoveToPlayer();
	    }
	    else
	    {
	    	Idle();
	    }
    }
    
	private void DetectEnemies()
	{
		Collider[] HitPlayer = Physics.OverlapSphere(transform.position,Area,Player);
		float closestDistance = Mathf.Infinity;
		
		foreach (Collider e in HitPlayer)
		{
			float distance = Vector3.Distance(transform.position, e.transform.position);
			
			if (distance < closestDistance)
			{
				closestDistance = distance;
				EnemyTarget = e.gameObject;
			}
		}   
	}
	
	public void MoveToPlayer()
	{	

		transform.LookAt (EnemyTarget.transform.position);
		//transform.Rotate (new Vector3 (0, -90, 0), Space.Self);

		if (Vector3.Distance (transform.position, EnemyTarget.transform.position) > Area) 
		{
			Idle();
		}
		else if(Vector3.Distance (transform.position, EnemyTarget.transform.position) > 2.5f) 
		{
			Walking();
		}
		else if(Vector3.Distance (transform.position, EnemyTarget.transform.position) <= 2.5f)
		{
			Attacking();
		}
	}
	
	private void OnDrawGizmosSelected()
	{
		try
		{
			Gizmos.DrawWireSphere(transform.position, Area);
		}
			catch (System.Exception)
			{
				return;
			}
	}
	
	private void Idle()
	{
		EnemyAnimator.SetBool("isIdle",true);
		EnemyAnimator.SetBool("isWalking",false);
		EnemyAnimator.SetBool("isAttacking",false);
		EnemyAnimator.SetBool("isDead",false);
	}
	
	private void Walking()
	{
		moveDirection = EnemyTarget.transform.position;
		Speed = 5f;
		EnemyAnimator.SetBool("isWalking",true);
		EnemyAnimator.SetBool("isIdle",false);
		EnemyAnimator.SetBool("isAttacking",false);
		EnemyAnimator.SetBool("isDead",false);
		transform.position = Vector3.MoveTowards(transform.position, moveDirection, Speed * Time.deltaTime);
	}
	
	private void Attacking()
	{
		moveDirection = EnemyTarget.transform.position;
		Speed = 0f;
		EnemyAnimator.SetBool("isAttacking",true);
		EnemyAnimator.SetBool("isIdle",false);
		EnemyAnimator.SetBool("isWalking",false);
		EnemyAnimator.SetBool("isDead",false);
		transform.position = Vector3.MoveTowards(transform.position, moveDirection, Speed * Time.deltaTime);
	}
	
	private void Dead()
	{
		EnemyAnimator.SetBool("isDead",true);
		EnemyAnimator.SetBool("isIdle",false);
		EnemyAnimator.SetBool("isWalking",false);
		EnemyAnimator.SetBool("isAttacking",false);
	}
	

}


























