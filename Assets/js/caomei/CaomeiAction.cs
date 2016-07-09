using UnityEngine;
using System.Collections;

public class CaomeiAction : MonoBehaviour {
	public GameObject texiao;//
	private ParticleSystem ps;
	public GameObject caomeicope;
	// Use this for initialization
	void Start () {
		ps = texiao.GetComponent<ParticleSystem> ();
		caomeicope.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(-Vector3.up*Time.deltaTime*30,Space.World);//自转
		if (ps.isStopped) {
			ps.Play ();
		}
	}
	void OnMouseDown() {

		if (caomeicope != null && caomeicope.activeSelf == false) {
			caomeicope.SetActive(true);
		} else if (caomeicope != null && caomeicope.activeSelf == true) {
			caomeicope.SetActive(false);
			transform.GetComponent<Getscale>().start = Vector3.zero;
		} 
		
	}
}
