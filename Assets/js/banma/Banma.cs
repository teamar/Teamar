﻿using UnityEngine;
using System.Collections;

public class Banma : MonoBehaviour {
	private Animation getHit;
	private Animation trot;
	private Animation idleLookAround;
	private Animation galop;
	private int count = 0;
	private Vector2 direction;
	// Use this for initialization
	void Start () {
		getHit = gameObject.GetComponent<Animation> ();
		trot = gameObject.GetComponent<Animation> ();
		galop = gameObject.GetComponent<Animation> ();
		idleLookAround = gameObject.GetComponent<Animation> ();
		InvokeRepeating("addcount", 2, 3.0F);
		InvokeRepeating ("randomDirection" ,1f,3f);//
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 0) {
			getHit.Play ("getHit");
		} else if (count == 1) {
			if (!trot.IsPlaying("trot")) {
				trot.Play("trot");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} else if (count == 2) {
			if (!idleLookAround.IsPlaying("idleLookAround")) {
				idleLookAround.Play("idleLookAround");
			}
			//Rotating (direction.x, direction.y);
			//moving (direction.x, direction.y);
		} else if (count == 3) {
			if (!galop.IsPlaying("galop")) {
				galop.Play("galop");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		}  else if (count == 4) {
			if (!trot.IsPlaying("trot")) {
				trot.Play("trot");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} 
	}
	void Rotating (float horizontal, float vertical)
	{
		Vector3 postionV = gameObject.transform.parent.position;
		Debug.Log (Vector3.Distance (gameObject.transform.position, postionV)  +"--"+postionV.x+"---"+postionV.y);
		Vector3 targetDirection;
		if (Vector3.Distance (gameObject.transform.position, postionV) > 0.5f) {
			targetDirection = new Vector3(-gameObject.transform.position.x, 0, -gameObject.transform.position.z);// Create a new vector of the horizontal and vertical inputs.
		} else {
			targetDirection = new Vector3 (-horizontal, 0f, -vertical); // Create a new vector of the horizontal and vertical inputs.
		}
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up); // Create a rotation based on this new vector assuming that up is the global y axis.
		Quaternion newRotation = Quaternion.Lerp(gameObject.transform.rotation, targetRotation, 2 * Time.deltaTime); // Create a rotation that is an increment closer to the target rotation from the player's rotation.
		gameObject.transform.rotation = newRotation; // Change the players rotation to this new rotation.
	}
	public void moving (float h, float v) {
		Debug.Log (h+"----------"+v);
		//往前走
		if (h > 0) {
			//Debug.Log("向右"+h);
			gameObject.transform.Translate(0,0,h*Time.deltaTime*0.3f);
		}
		if (h < 0) {
			//Debug.Log("向左"+h);
			gameObject.transform.Translate(0,0,-h*Time.deltaTime*0.3f);
		}
		if (v > 0) {
			//Debug.Log("向前"+v);
			gameObject.transform.Translate(0,0,v*Time.deltaTime*0.3f);
		}
		if (v < 0) {
			//Debug.Log("向后"+v);
			gameObject.transform.Translate(0,0,-v*Time.deltaTime*0.3f);
		}
		
		
	}
	public void randomDirection() {//随机单位方向
		direction = Random.onUnitSphere.normalized;
	}
	void addcount()  {
		count++;
		if (count == 5) {
			count = 0;
		}
	}
}
