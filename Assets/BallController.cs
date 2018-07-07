using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {	

	private float  speed = 10.0f;
	private CharacterController controller;
	Vector3 moveDirection;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		var dir = Vector3.zero;

		// 端末の傾き取得
		dir.x = Input.acceleration.x;
		dir.z = Input.acceleration.y;

		// ベクトルが大きかったら正規化
		if (dir.sqrMagnitude > 1)
			dir.Normalize();

		// Make it move 10 meters per second instead of 10 meters per frame...
		dir *= Time.deltaTime;

		// Move object
		transform.Translate (dir * speed);

	}

}
