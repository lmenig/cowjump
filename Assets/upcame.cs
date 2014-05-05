using UnityEngine;
using System.Collections;

public class upcame : MonoBehaviour {
	public GameObject cow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 dst = this.transform.position;
		dst.y = cow.transform.position.y;
		this.transform.position = dst;
		this.transform.LookAt (cow.transform.position);
	}
}
