using UnityEngine;
using System.Collections;

public class MenuClickListener : MonoBehaviour {


	public void OnPlayClicked()
	{
		Application.LoadLevel ("GameScene");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
