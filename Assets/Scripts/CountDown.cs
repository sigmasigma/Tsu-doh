using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CountDown : MonoBehaviour {

	public GameObject[] StoppedObjects;

	// Use this for initialization
	void Start () {
		StartCoroutine("DispCountDown");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator DispCountDown() {
		for(int i = 0; i < StoppedObjects.Length; i++){
			foreach(Behaviour bahav in StoppedObjects[i].GetComponentsInChildren<Behaviour>()){
				bahav.enabled = false;
			}
			StoppedObjects[i].GetComponent<Rigidbody2D>().Sleep();
		}
		Text subText = GameObject.Find("restart").GetComponent<Text>();
		subText.text = "";
		Text mainText = GameObject.Find("countdown_text").GetComponent<Text>();
		mainText.fontSize = 300;
		mainText.text = "3";
		yield return new WaitForSeconds (1f);
		mainText.text = "2";
		yield return new WaitForSeconds (1f);
		mainText.text = "1";
		yield return new WaitForSeconds (1f);
		mainText.text = "";
		for(int i = 0; i < StoppedObjects.Length; i++){
			foreach(Behaviour bahav in StoppedObjects[i].GetComponentsInChildren<Behaviour>()){
				bahav.enabled = true;
			}
			StoppedObjects[i].GetComponent<Rigidbody2D>().WakeUp();
		}
	}
}
