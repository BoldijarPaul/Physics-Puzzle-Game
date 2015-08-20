using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// load level
		string contents;
		using (var wc = new System.Net.WebClient())
			contents = wc.DownloadString("http://paulboss.site90.net/level.xml");

		XMLLoader.InstantiateFromXML (contents);

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
