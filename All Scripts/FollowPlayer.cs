using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : UnityEngine.MonoBehaviour
{
	[SerializeField] private float xaxis;
	[SerializeField] private float yaxis;
	[SerializeField] private float zaxis;

	//[SerializeField] private float xrotation = 27.5f;
	//[SerializeField] private float yrotation = 90;
    //[SerializeField] private float zrotation = 0;

    [SerializeField] private Transform player;

    void Update()
    {
	    transform.position = new Vector3 (player.position.x + xaxis, player.position.y + yaxis, player.position.z + zaxis);
	    //transform.position = new Vector2(player.position.x + xaxis, player.position.y + yaxis);
        
	    //transform.rotation = Quaternion.Euler(player.rotation.x + xrotation, player.rotation.y + yrotation, player.rotation.z);
    }
}
