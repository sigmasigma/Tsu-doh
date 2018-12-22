using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFollower : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D c){
		if(c.gameObject.CompareTag("wave")){
			Destroy(gameObject);
		}
		if(c.gameObject.CompareTag("goal")){
			GameObject.Find("GameManager").GetComponent<ManageStageClear>().AddEscaper();
			Destroy(gameObject);
		}
	}
}
