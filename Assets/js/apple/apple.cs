using UnityEngine;
using System.Collections;

public class apple : MonoBehaviour {
	public GameObject sApple; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		sApple.SetActive (true);
		Animation pingguo = sApple.GetComponent<Animation>();
		pingguo.Play ();
		gameObject.SetActive (false);//让自己消失，设置为false
	}
}
