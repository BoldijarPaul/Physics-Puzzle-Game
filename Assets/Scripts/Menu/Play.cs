using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {


	void OnMouseUp()
	{
		Debug.Log ("test");
		Application.LoadLevel ("GameScene");
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
