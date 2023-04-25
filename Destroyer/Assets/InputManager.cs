using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
	public Vector3 GetMovementVectorNormalized()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		
		Vector3 movementVector = new Vector3(horizontal,0f,vertical);
		
		movementVector = movementVector.normalized;
		return movementVector;
	}
}
