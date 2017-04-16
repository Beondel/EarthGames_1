using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private float speed;

	void Start () {
		speed = 5;
	}
		
	void Update () {
		float axisX = Input.GetAxis("Horizontal");
		float axisY = Input.GetAxis("Vertical");
		transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * speed);
	}
}