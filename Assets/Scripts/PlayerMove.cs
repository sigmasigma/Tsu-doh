using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 右・左
    	float x = Input.GetAxisRaw ("Horizontal");
		// 上下
		float y = Input.GetAxisRaw("Vertical");
    	// 移動する向きを求める
    	Vector2 direction = new Vector2 (x, y).normalized;
    	// 移動する向きとスピードを代入する
    	GetComponent<Rigidbody2D>().velocity = direction * Speed;
	}
}
