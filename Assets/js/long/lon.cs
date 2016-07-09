using UnityEngine;
using System.Collections;

public class lon : MonoBehaviour {
	private Animation slon;
	private Vector3 start = new Vector3(0,0,0);
	private Vector3 end = new Vector3(0.2f,0.2f,0.2f);
	private float factor = 0.0008f;
	public GameObject fireman;
	private ParticleSystem fire;
	// Use this for initialization
	void Start () {
		slon = gameObject.GetComponent<Animation>();
		fire = fireman.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (slon.isPlaying == false) {
			slon.Play ("Take 001");
			Debug.Log(slon.clip.name+"zhoonggg");
			fire.Play();
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
