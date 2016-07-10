using UnityEngine;
using System.Collections;

public class xialu : MonoBehaviour {
	public Animation slu;
	private Vector3 start = new Vector3(0,0,0);
	private Vector3 end = new Vector3(5,5,5);
	private float factor = 0.02f;
	// Use this for initialization
	void Start () {
		slu = gameObject.GetComponent<Animation>();
		//slu.Play(0);
	}
	
	// Update is called once per frame
	void Update () {
		if (slu.isPlaying == false) {
			slu.Play ("Take 001");
			//Debug.Log(slon.clip.name+"zhoonggg");
		}
		//if (start.x >= end.x&&start.y>=end.y&&start.z >= end.z) {
		//	return;
		//}
		
		//Vector3 scale = new Vector3(start.x + factor,
		//                            start.y + factor, 
		//                            start.z + factor);
		//transform.localScale = scale;
		//start = scale;
	}
}
