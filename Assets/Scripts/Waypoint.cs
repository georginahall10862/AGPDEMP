﻿using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour
{
	[SerializeField]
	float debugDrawRadius = 1.0F;

	void OnDrawGizmos()
	{
		
		Gizmos.DrawWireSphere(transform.position, debugDrawRadius);
	}
}