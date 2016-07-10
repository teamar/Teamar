using UnityEngine;
using System.Collections;


public class SelfRotate : MonoBehaviour {
	public float roatespeed = 5f ;
	public Vector3 rotateAg = Vector3.up;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotateAg*Time.deltaTime*roatespeed,Space.Self);//自转
	}
}
