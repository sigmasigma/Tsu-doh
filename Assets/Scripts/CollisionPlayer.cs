using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {}

	void OnTriggerEnter2D (Collider2D c){
		if(c.gameObject.CompareTag("wave")){
			GameObject.Find("GameManager").GetComponent<ManageGameOver>().GameOver();
			Destroy(gameObject);
		}
		if(c.gameObject.CompareTag("goal")){
			GameObject.Find("GameManager").GetComponent<ManageStage1Clear>().StageClear();
		}
	}
}
