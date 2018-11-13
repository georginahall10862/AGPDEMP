using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyBottle : MonoBehaviour
{
	public Text Wine;
	int count;

	void OnCollisionEnter (Collision col)
	{
		print ("bottled");
		if(col.gameObject.tag == "Bottle")
		{
			Destroy(col.gameObject);
			count++;
		}
	}
	void Update (){
		Wine.text = "Wine = " + count;
	}
}