using UnityEngine;
using System.Collections;
public class CommenAction : MonoBehaviour  {
	public Vector3 start = new Vector3(0,0,0);
	public Vector3 end = new Vector3(0.5f,0.5f,0.5f);
	public float factor=0.04f;
	public GameObject controll;
	private int count=0;
	public GameObject phySys;
	public GameObject phySys2;
	private ParticleSystem partSys;
	private ParticleSystem partSys2;
	public GameObject roateObj;
	private bool isactive = true;
	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (0,0,0);
		partSys = phySys.GetComponent<ParticleSystem>();
		partSys2 = phySys2.GetComponent<ParticleSystem>();
		partSys.Stop ();
		partSys2.Stop();
	}
	
	// Update is called once per frame
	void Update () {


		addCount ();
		if (count == 1) {//旋转
			if (partSys.isStopped) {
				partSys.Play();
			}
			if (partSys2.isStopped) {
				partSys2.Play();
			}
			controll.GetComponent<CommentUtil>().clickRorate(roateObj, Vector3.up, 500f);
		} else if (count == 2 && isactive == true) {
			start = new Vector3(0,0,0);
			partSys.Stop();
			partSys2.Stop();
			isactive = false;
		} 

		if (start.x >= end.x&&start.y>=end.y&&start.z >= end.z) {
			return;
		}

		Vector3 scale = new Vector3(start.x + factor,
		                            start.y + factor*2, 
		                            start.z + factor);
		transform.localScale = scale;
		start = scale;


	}

	//累计
	public void addCount() {
		//点击旋转
		//if (Input.touchCount > 0) {
			//for (var i = 0; i < Input.touchCount; ++i) {
				//if (Input.GetTouch(i).phase == TouchPhase.Began) {
				//	count++;
				//	break;	
				//}
			//}
			//Debug.Log("鼠标按下"+ count);
		//}
		if (Input.GetMouseButtonUp(0)) {
			count++;
			Debug.Log("鼠标按下"+ count);
		}
		if (count == 3) {
			count = 1;
			isactive = true;
		}
	}
}
