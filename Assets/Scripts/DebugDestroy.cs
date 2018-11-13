using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDestroy : MonoBehaviour {

	void OnDestroy () {
		Debug.Log ("Destroy");
	}
}
