using UnityEngine;
using System.Collections;

public class ShoujiVibration : MonoBehaviour {

    public AudioClip vibration;
    public AudioSource source;
    public Animation anim;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void Play()
    {
        source.clip = vibration;
        source.Play();
        anim.Play();
    }
}
