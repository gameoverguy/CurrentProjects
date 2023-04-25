using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyUnitAI : MonoBehaviour
{
	[SerializeField] private float Area = 6f;
	float turnSmoothTime = 0.1f;
	float turnSmoothVelocity;
	//public GameObject Something;
	public GameObject PrimaryTarget;
	[SerializeField] private NavMeshAgent basicEnemy;
	
	public GameObject EnemyTarget;
	[SerializeField] private LayerMask Player;
	
	[SerializeField] private Animator EnemyAnimator;
	
	private Vector3 moveDirection;
	
	private string currentAnimaton;
	
	//Animation States
	const string ENEMY_IDLE = "enemy_idle";
	const string ENEMY_ATTACK = "enemy_attack";
	const string ENEMY_RUN = "enemy_run";
	const string ENEMY_DEATH = "enemy_death";
	
	private void Awake()
	{
		Enemies.enemies.Add(gameObject);
	}
	
    // Start is called before the first frame update
    void Start()
    {
	    basicEnemy = GetComponent<NavMeshAgent>();
	    PrimaryTarget = GameObject.Find("Player");
	    //EnemyTarget = PrimaryTarget;
    }

    // Update is called once per frame
    void Update()
	{
		//DetectPlayer();
		
		MoveToTarget();
		
		/*
		if(EnemyTarget == Something)
		{
			
		}
		
		
		if(EnemyTarget != Something)
		{
			MoveToPlayer();
		}
		*/
		

    }
    
	/*
	private void DetectPlayer()
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
			
			if(distance > Area)
			{
				EnemyTarget = Something;
			}
		}

	}
	
	
	private void MoveToPlayer()
	{
		var direction = (EnemyTarget.transform.position - transform.position).normalized;
		
		float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
		float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
		transform.rotation = Quaternion.Euler(0f, angle, 0f);
			
		float distance = Vector3.Distance(transform.position, EnemyTarget.transform.position);

		if(distance <= Area & distance >= 1.2f)
		{
			basicEnemy.isStopped = false;
			ChangeAnimationState(ENEMY_RUN);
			basicEnemy.SetDestination(EnemyTarget.transform.position);
		}
		else if(distance < 1.2f)
		{
			ChangeAnimationState(ENEMY_ATTACK);
		}

	}
	*/
	
	private void MoveToTarget()
	{
		var direction = (PrimaryTarget.transform.position - transform.position).normalized;
		float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
		float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
		transform.rotation = Quaternion.Euler(0f, angle, 0f);
		
		RaycastHit hitinfo;
		bool canMove = !Physics.Raycast(transform.position,direction,out hitinfo, 1.5f);
		
		if(canMove)
		{
			ChangeAnimationState(ENEMY_RUN);
			basicEnemy.SetDestination(PrimaryTarget.transform.position);
		}

		
		if(!canMove)
		{
			if(hitinfo.collider.gameObject.GetComponent<Crystal>())
			{
				ChangeAnimationState(ENEMY_ATTACK);
				basicEnemy.isStopped = true;
			}
		}
		
		
	}
	
	
	private void OnDrawGizmosSelected()
	{
		try
		{
			Gizmos.DrawWireSphere(transform.position, Area);
			Gizmos.DrawLine(transform.position,EnemyTarget.transform.position);
		}
			catch (System.Exception)
			{
				return;
			}
	}
	
	
	void ChangeAnimationState(string newAnimation)
	{
		if (currentAnimaton == newAnimation) return;

		EnemyAnimator.Play(newAnimation);
		currentAnimaton = newAnimation;
	}
	

}


























