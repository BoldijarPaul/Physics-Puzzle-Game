using UnityEngine;
using System.Collections;

public class FinishPlatform : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider2D)
	{
		UIManager.ShowLevelClearedMenu (true);
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
