using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text Wine;
	public int count;

	void Update()
	{
		Wine.text = "Wine = " + count * 10;
	}
}
