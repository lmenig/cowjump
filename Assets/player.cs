using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter(Collision collision) {
		Debug.Log ("collision");
				this.rigidbody.AddForce(Vector3.up * 1000);
		}
	// Update is called once per frame
	void Update () {			
		if (Input.GetKey(KeyCode.LeftArrow))
			this.rigidbody.AddForce (-Vector3.forward * 50, ForceMode.Impulse);
		if (Input.GetKey(KeyCode.RightArrow))
			this.rigidbody.AddForce (Vector3.forward * 50, ForceMode.Impulse);
		if (Input.GetKey (KeyCode.UpArrow))
			this.rigidbody.AddForce (Vector3.left * 50, ForceMode.Impulse);
		if (Input.GetKey(KeyCode.DownArrow))
			this.rigidbody.AddForce (Vector3.right * 50, ForceMode.Impulse);
		if (Input.GetKey (KeyCode.Space)) {
			rigidbody.velocity = Vector3.zero;
				}
		
		//; ;
		GUI.Label(new Rect(Screen.width * 0.5f - 50f, Screen.height * 0.5f - 10f, 100f, 20f), "fuck\t");
	}
}
