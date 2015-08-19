using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			/* clicked escape, restart scene */
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
