﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public GameObject centerPosition;
	public float speed = 10;
	public Vector3 rotateAg = -Vector3.up;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (centerPosition.transform.position, rotateAg, Time.deltaTime*speed);//公转

	}
}