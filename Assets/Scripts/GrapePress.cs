using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrapePress : MonoBehaviour {

	public PlayerController pC;
	public GameObject GrapeSquished;
	public Text GrapepressTimer;
	public int TimeRemaining = 30;

	bool one;

	// Use this for initialization
	void Start () {
		pC = GameObject.Find ("PlayerMove").GetComponent<PlayerController> ();
		GrapeSquished = (GameObject)Resources.Load ("Grape_Squished", typeof(GameObject));
	}

	// Update is called once per frame
	void Update () {
		GrapepressTimer.text = "Timer: " + TimeRemaining;
	}
	void OnTriggerStay(Collider other){

		if (other.gameObject.tag == "Grape" && pC.pickedUp == false && one == false) {
			Destroy (other.gameObject);
			StartCoroutine (Blend ());
			one = true;
		}
	}
	IEnumerator Blend () {
		GrapepressTimer.enabled = true;
		print ("Cooking");
		for (int i = 0; i < TimeRemaining; i++)
		{
			yield return new WaitForSeconds (1.0f); // change number for cook time
			TimeRemaining --;
			if (TimeRemaining == 0) {
				break;
			}
			//print("...");
		}
		//print ("Done");
		yield return null;
		GameObject Spawn;
		Spawn = Instantiate(GrapeSquished);
		Spawn.transform.parent = transform;
		Spawn.transform.localPosition = new Vector3 (0, 0.5f, 0);
		one = false;
	}
}
