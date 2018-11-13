using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrel : MonoBehaviour {
	public PlayerController pC;
	public GameObject Spawn;
	public GameObject Bottle;
	//public Countdown barrelTimer;
	public int TimeRemaining = 45;
	public Text Timer;
	public bool Yeast;
	bool SGrape;

	// Use this for initialization
	void Start () {
		pC = GameObject.Find ("PlayerMove").GetComponent<PlayerController> ();
		Bottle = (GameObject)Resources.Load ("Bottle", typeof(GameObject));	
		Spawn = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Timer.text = "Timer: " + TimeRemaining;
	}
	void OnTriggerStay(Collider other){

		if (other.gameObject.tag == "SGrape" && pC.pickedUp == false) {
			Debug.LogFormat ("dropped {0}", other.gameObject.tag);
			Destroy (other.gameObject);
			SGrape = true;
		}
		if (other.gameObject.tag == "Yeast" && pC.pickedUp == false) {
			Destroy (other.gameObject);
			Debug.Log ("Drop yeast");
			Yeast = true;
		}
		if (Yeast == true && SGrape == true) {
			Yeast = false;
			SGrape = false;
			StartCoroutine (Blend ());
		}
	}
	IEnumerator Blend () {
		//barrelTimer.enabled = true;

		for (int i = 0; i < TimeRemaining; i++)
		{
			yield return new WaitForSeconds (1.0f); // change number for cook time
			TimeRemaining --;
			Timer.text = "Timer: " + TimeRemaining;
			if (TimeRemaining == 0) {
				break;
			}
			//print("...");
		}
		Spawn = Instantiate(Bottle);
		Spawn.transform.parent = transform;
		Spawn.transform.localPosition = new Vector3 (0, 0.5f, 0);
	}
}
