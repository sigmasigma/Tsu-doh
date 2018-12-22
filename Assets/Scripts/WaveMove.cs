using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMove : MonoBehaviour {

	Rigidbody2D rb;
	public float WaveSpeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector3(-1 * WaveSpeed,-1 * WaveSpeed,0f);
	}
}
