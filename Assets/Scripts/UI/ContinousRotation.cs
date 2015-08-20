using UnityEngine;
using System.Collections;

public class ContinousRotation : MonoBehaviour {
	public float ROTATION_CONSTANT=4;
	public Vector3 VECTOR=Vector3.up;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (VECTOR * ROTATION_CONSTANT * Time.deltaTime);
	}
}
