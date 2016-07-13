using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public GameObject plane;
	public float distance = 0.005f;
	public float TranslateSpeed = 0.05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((transform.position.y - plane.transform.position.y)  >= 0.005f) {
			return;
		}
		Debug.Log (transform.position.y);
		transform.Translate(Vector3.up *TranslateSpeed);
	}
}
