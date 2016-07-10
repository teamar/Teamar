using UnityEngine;
using System.Collections;

public class Getscale : MonoBehaviour {
	public Vector3 start = new Vector3(0,0,0);
	public Vector3 end = new Vector3(2.0f,2.0f,2.0f);
	public float factor=0.04f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (start.x >= end.x&&start.y>=end.y&&start.z >= end.z) {
			return;
		}
		
		Vector3 scale = new Vector3(start.x + factor,
		                            start.y + factor, 
		                            start.z + factor);
		transform.localScale = scale;
		start = scale;
	}
}
