using UnityEngine;
using System.Collections;

public class CommentUtil : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//自转  roatateAg角度  roatespeed是速度
	public void clickRorate(GameObject gameObj, Vector3 rotateAg, float roatespeed) {
		gameObj.transform.Rotate(rotateAg*Time.deltaTime*roatespeed,Space.Self);//自转
	}
}
