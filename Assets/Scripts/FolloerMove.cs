using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloerMove : MonoBehaviour {

	GameObject player;
	Rigidbody2D rigidbody;
	float FollowerSpeed = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find("player");
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, FollowerSpeed*Time.deltaTime);
	}
}
