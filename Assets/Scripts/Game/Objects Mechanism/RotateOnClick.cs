using UnityEngine;
using System.Collections;

public class RotateOnClick : MonoBehaviour {
	public float ROTATING_SPEED=50;

	// Use this for initialization
	void Start () {
	
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButton (0)) {
			transform.Rotate(0,0,ROTATING_SPEED*Time.deltaTime);
		}
		 

	}
	// Update is called once per frame
	void Update () {
	
	}
}
