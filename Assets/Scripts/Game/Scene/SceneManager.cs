using UnityEngine;
using System.Collections;
using System.IO;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIManager.Load ();
	
		
	
		 
		GameObject[] obj = (GameObject[])GameObject.FindObjectsOfType (typeof(GameObject));
		GameItem[] items = XMLSaver.GameObjectsToGameItemArray (obj, "Static");
		FileHelper.SaveStringToFile ("level.xml", XMLHelper.ObjectToXML (items));
		 


		/*
		// load level
		string contents;
		using (var wc = new System.Net.WebClient())
			contents = wc.DownloadString("http://paulboss.site90.net/level.xml");

		StreamReader reader = new StreamReader ("level.xml");

		XMLLoader.InstantiateFromXML (reader.ReadToEnd());
		reader.Close ();
		*/

 

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
