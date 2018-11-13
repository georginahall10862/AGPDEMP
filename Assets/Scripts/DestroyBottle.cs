using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyBottle : MonoBehaviour
{
	public Text Wine;
	int count;

	void OnTriggerEnter (Collider col)
	{
		/*print ("bottled");
		if(col.gameObject.tag == "Bottle")
		{
			Destroy(col.gameObject);
			count++;
		}*/
	}
}