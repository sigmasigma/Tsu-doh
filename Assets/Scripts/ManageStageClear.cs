using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
public class ManageStageClear : MonoBehaviour {

	bool isClear;
	int escapedNumber = 0;
	// Use this for initialization
	void Start () {
		isClear = false;
		int escapedNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(isClear){
			Text mainText = GameObject.Find("countdown_text").GetComponent<Text>();
			mainText.fontSize = 90;
			mainText.text = "ステージクリア！\n" +escapedNumber.ToString()+"人救出！";
			Text subText = GameObject.Find("restart").GetComponent<Text>();
			subText.text = "Press Space key";
			if (Input.GetKey("space")) {
				isClear = false;
				Scene loadScene = SceneManager.GetActiveScene();
				if(loadScene.name.Equals("Stage1")){
					SceneManager.LoadScene("Stage2");
				}else if(loadScene.name.Equals("Stage2")){
					SceneManager.LoadScene("Ending");
				}
			}
		}
	}

	public void StageClear(){
		isClear = true;
	}

	public void AddEscaper(){
		escapedNumber++;
	}
}
