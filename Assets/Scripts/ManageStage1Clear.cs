using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
public class ManageStage1Clear : MonoBehaviour {

	bool isClear;
	// Use this for initialization
	void Start () {
		isClear = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isClear){
			if (Input.GetKey("space")) {
				isClear = false;
				SceneManager.LoadScene("Stage2");
			}
		}
	}

	public void StageClear(){
		Text mainText = GameObject.Find("countdown_text").GetComponent<Text>();
		mainText.fontSize = 100;
		mainText.text = "StageClear!";
		Text subText = GameObject.Find("restart").GetComponent<Text>();
		subText.text = "Press Space key";
		isClear = true;
	}
}
