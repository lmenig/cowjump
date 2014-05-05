using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
		public GameObject platform;
		public Transform lastpos;
		//public GameObject camera;
		// Use this for initialization
		void Start ()
		{
				lastpos = platform.transform;
		}
	
		// Update is called once per frame
		void Update ()
		{
				Transform newpos = lastpos;
				Vector3 vect = lastpos.position;
				if (vect.y < Camera.current.transform.position.y) {
						vect.y = lastpos.position.y + Random.Range (10, 50);
						vect.z = Random.Range (-40, 40);
						vect.x = Random.Range(-20,20);
						newpos.position = vect;
						Object inst = Instantiate (platform, newpos.position, newpos.rotation);
						lastpos = newpos;
						Destroy (inst, 20);
				}

		}
}
