using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	int MaxMove;
	public int speed;
	public int sprint;
	public bool pick;
	public bool pickedUp;
	public bool drop;
	public GameObject Player;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.LeftShift)) {
			MaxMove = sprint;
		} else {
			MaxMove = speed;
		}
		if (Input.GetKey (KeyCode.A) && rb.velocity.magnitude < MaxMove) {
			rb.AddForce (transform.right * -speed);
			Player.transform.eulerAngles = new Vector3 (0, 270, 0);
		}
		if (Input.GetKey (KeyCode.W) && rb.velocity.magnitude < MaxMove) {
			rb.AddForce (transform.forward * speed);
			Player.transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.S) && rb.velocity.magnitude < MaxMove) {
			rb.AddForce (transform.forward * -speed);
			Player.transform.eulerAngles = new Vector3 (0, 180, 0);
		}
		if (Input.GetKey (KeyCode.D) && rb.velocity.magnitude < MaxMove) {
			rb.AddForce (transform.right * speed);
			Player.transform.eulerAngles = new Vector3 (0, 90, 0);
		}
		Player.transform.localPosition = new Vector3 (0, 0, 0);
		if (Input.GetKeyDown (KeyCode.E)) {
			if (pickedUp == true) {
				drop = true;
			} else {
				pick = true;
			}
		} else {
			drop = false;
			pick = false;
		}
	}
	//	void Update () {
			//float mouseInput = Input.GetAxis("Mouse X");
			//Vector3 lookhere = new Vector3(0,mouseInput,0);
		//	transform.Rotate(lookhere);
		//}

		}
