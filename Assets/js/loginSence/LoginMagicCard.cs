using UnityEngine;
using System.Collections;

public class LoginMagicCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("dddddd");
			Ray ray = UICamera.mainCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;  
			if (Physics.Raycast(ray, out hit)) {
				Debug.Log("gggggggggggggggggggg");
				if (hit.collider.gameObject.name == this.name) {
					Debug.Log("ffffffffffff");
					Application.LoadLevel("card");
				}
			}  
		}
	}

}
