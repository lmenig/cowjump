using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter (Collision other)
	{
		other.rigidbody.AddForce(Vector3.up * 200, ForceMode.Impulse);
		Debug.Log ("collider");
	}
	// Update is called once per frame
	void Update () {

	
	}
}
