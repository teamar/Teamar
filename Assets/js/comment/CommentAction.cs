using UnityEngine;
using System.Collections;

public class CommentAction : MonoBehaviour {
	public Vector3 start = new Vector3(0,0,0);
	public Vector3 end = new Vector3(0.2f,0.2f,0.2f);
	public float factor = 0.001f;
	private ParticleSystem ps;
	private Animation slon;
	public GameObject partSysObj;
	// Use this for initialization
	void Start () {
		slon = gameObject.GetComponent<Animation>();
		ps = partSysObj.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (slon.isPlaying == false) {
			slon.Play ();
		}
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
