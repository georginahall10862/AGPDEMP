using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

	public PlayerController pC;
	public Score score;
	bool holding = false;
	public bool IsBottle = false;

	void Start () { 
		pC = GameObject.Find ("PlayerMove").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (pC.pickedUp == true && holding) {
			transform.localPosition = new Vector3 (0, 0, 1);
		}
	}

	void OnTriggerStay(Collider other){
		print ("ppp");
		if (other.gameObject.tag == "Player" && pC.pick == true) {
			print ("PlayerIn " + gameObject.tag);
			holding = true;
			Debug.LogFormat ("Picked up {0}", name);
			gameObject.transform.parent = other.transform.GetChild(0); // make child of the child. Be a grandma.
			transform.localPosition = new Vector3 (0,0,1);
			pC.pickedUp = this;
		}
		else if (other.gameObject.tag == "DropOff" && pC.drop == true && pC.pickedUp == this) {
			holding = false;
			Debug.LogFormat ("Dropped {0}", name);
			gameObject.transform.parent = other.transform;
			pC.drop = false;
			pC.pickedUp = null;
			if (IsBottle) {
				score.count++;
				Destroy (gameObject);
			}
		}
		else if (other.gameObject.tag == "WorkTop" && pC.drop == true && pC.pickedUp == this) {
			holding = false;
			Debug.LogFormat ("Dropped {0}", name);
			gameObject.transform.parent = other.transform;
			pC.drop = false;
			pC.pickedUp = null;
			//transform.localPosition = new Vector3 (0,0.65f,0);
		}
	}
}
