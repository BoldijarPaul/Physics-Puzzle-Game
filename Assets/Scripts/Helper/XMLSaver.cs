using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class XMLSaver  {

		
	/* add all the properties from a game object to the Game Item model */
	public static GameItem GameObjectToGameItem(GameObject gameObject)
	{
		GameItem gameItem = new GameItem ();
		gameItem.name = gameObject.name;
		gameItem.position = gameObject.transform.position;
		gameItem.rotation = gameObject.transform.eulerAngles;
		gameItem.scale = gameObject.transform.localScale;

		return gameItem;
	}


	/* converts a list of gameobjects to gameitem models 
	 the objects with the ignored tag will not be added */
	public static GameItem[] GameObjectsToGameItemArray(GameObject[] gameObjects,string ignoreTag)
	{
		List<GameItem> gameItems = new List<GameItem> ();
		foreach (GameObject gameObject in gameObjects) 
		{
			if (gameObject.tag == ignoreTag)	continue;
			gameItems.Add (GameObjectToGameItem (gameObject));
		}

		return gameItems.ToArray();
	}
}
