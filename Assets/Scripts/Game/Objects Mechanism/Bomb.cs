﻿using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

public class Bomb : MonoBehaviour {
	public Vector2 BULLET_FORCE =new Vector2(-1000,0);
	private int clickCount;

	// Use this for initialization
	void Start () {
		 
		clickCount = 0;
			 

	}

	 
	void OnMouseUp()
	{
		if (clickCount != 0)
			return;

		/* we clicked this bullet */
		/* let's apply some force! */
		GetComponent<Rigidbody2D> ().isKinematic = false;
		GetComponent<Rigidbody2D> ().AddForce (BULLET_FORCE);
		clickCount++;
	}
	 
	 
	 
}
