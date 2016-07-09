using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using EasyAR;
public class Source : MonoBehaviour {
	private AudioSource[] sources;
	public GameObject easyAR;
	public GameObject sourceManager;
	private AudioSource source;
	public AudioClip moguClipEnglish;
	public AudioClip moguClipChina;

	public AudioClip shayuClipEnglish;
	public AudioClip shayuClipChina;


	public AudioClip caomeiClipEnglish;
	public AudioClip caomeiClipChina;
	public GameObject uiCanvas;//单词 中文和英文
	// Use this for initialization
	void Start () {
		source = sourceManager.GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (source != null && !source.isPlaying) {
			uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="";
			uiCanvas.transform.Find("source").gameObject.SetActive(false);
		}
	}
	public void clickEnglish () {
		string targetName = easyAR.GetComponent<ARIsEasyBehaviour> ().targetName;

		if ("mogu".Equals(targetName)) {
			source.clip = moguClipEnglish;

			if (source != null) {
				source.Play();
				uiCanvas.transform.Find("source").gameObject.SetActive(true);
				uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="mushroom";

			}
		} else if ("shayu".Equals(targetName)) {
			source.clip = shayuClipEnglish;
			
			if (source != null) {
				source.Play();
				uiCanvas.transform.Find("source").gameObject.SetActive(true);
				uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="shark";
				
			}
		} else if ("caomei".Equals(targetName)) {
			source.clip = caomeiClipEnglish;
			
			if (source != null) {
				source.Play();
				uiCanvas.transform.Find("source").gameObject.SetActive(true);
				uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="strawberry";
				
			}
		}
	}
	public void clickChina () {
		string targetName = easyAR.GetComponent<ARIsEasyBehaviour> ().targetName;

		if ("mogu".Equals(targetName) ) {
			source.clip = moguClipChina;
			
			if (source != null) {
				source.Play();
				uiCanvas.transform.Find("source").gameObject.SetActive(true);
				uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="蘑菇";
			}
		} else if ("shayu".Equals(targetName) ) {
			source.clip = shayuClipChina;
			
			if (source != null) {
				source.Play();
				uiCanvas.transform.Find("source").gameObject.SetActive(true);
				uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="鲨鱼";
			}
		} else if ("caomei".Equals(targetName) ) {
			source.clip = caomeiClipChina;
			
			if (source != null) {
				source.Play();
				uiCanvas.transform.Find("source").gameObject.SetActive(true);
				uiCanvas.transform.FindChild("Text").GetComponent<Text> ().text="草莓";
			}
		}
	}
}
