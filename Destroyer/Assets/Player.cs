using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private int playerSpeed;
	public float turnSmoothTime = 0.1f;
	float turnSmoothVelocity;
	
	[SerializeField] private CharacterController Controller;
	[SerializeField] private InputManager inputManager;
	
	[SerializeField] private Animator anim;
	private string currentAnimaton;
	
	//Animation States
	const string PLAYER_IDLE = "player_idle";
	const string PLAYER_ATTACK = "player_attack";
	const string PLAYER_WALK = "player_walk";
	const string PLAYER_RUN = "player_run";
	const string PLAYER_CAST = "player_cast";
	const string PLAYER_DEATH = "player_death";
	
	
    // Start is called before the first frame update
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
	{
		Movement();
	}
    
	private void Movement()
	{
		
		Vector3 movementVector = inputManager.GetMovementVectorNormalized();
		float playerheight = 2f;
		float playerradius = 0.5f;
		float movDistance = playerSpeed * Time.deltaTime;
		bool canMove = !Physics.CapsuleCast(transform.position,transform.position + Vector3.up * playerheight,playerradius,movementVector,movDistance);
		
		if(!canMove)
		{
			
			Vector3 movementVectorX = new Vector3(movementVector.x,0,0).normalized;
			canMove = !Physics.CapsuleCast(transform.position,transform.position + Vector3.up * playerheight,playerradius,movementVectorX,movDistance);
			if(canMove)
			{
				movementVector = movementVectorX;
			}
			else
			{
				Vector3 movementVectorZ = new Vector3(0,0,movementVector.z).normalized;
				canMove = !Physics.CapsuleCast(transform.position,transform.position + Vector3.up * playerheight,playerradius,movementVectorZ,movDistance);
				if(canMove)
				{
					movementVector = movementVectorZ;
				}
			}
		}
		
		if(movementVector.magnitude >= 0.1f)
		{
			float targetAngle = Mathf.Atan2(movementVector.x, movementVector.z) * Mathf.Rad2Deg;
			float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
			transform.rotation = Quaternion.Euler(0f, angle, 0f);
			ChangeAnimationState(PLAYER_RUN);
			
			if(canMove)
			{
				Controller.Move(movementVector * movDistance);
			}
		}
		else
		{
			ChangeAnimationState(PLAYER_IDLE);
		}
	}
	
	private void RotateOrbs()
	{
		//Spawnpoint.Rotate(new Vector3(0, 30f, 0) * Time.deltaTime);
	}
	
	void ChangeAnimationState(string newAnimation)
	{
		if (currentAnimaton == newAnimation) return;

		anim.Play(newAnimation);
		currentAnimaton = newAnimation;
	}

}


















