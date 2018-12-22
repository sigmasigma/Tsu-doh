using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
public class ManageGameOver : MonoBehaviour {

	bool isGameover;

	// Use this for initialization
	void Start () {
		isGameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isGameover){
			if (Input.GetKey("space")) {
				isGameover = false;
				// 現在のScene名を取得する
				Scene loadScene = SceneManager.GetActiveScene();
				// Sceneの読み直し
				SceneManager.LoadScene(loadScene.name);
				
			}
		}
	}

	public void GameOver(){
		Text mainText = GameObject.Find("countdown_text").GetComponent<Text>();
		mainText.fontSize = 100;
		mainText.text = "GameOver";
		Text subText = GameObject.Find("restart").GetComponent<Text>();
		subText.text = "Press Space key";
		isGameover = true;
	}
}
