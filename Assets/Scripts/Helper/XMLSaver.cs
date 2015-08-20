using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class XMLSaver  {

		
	/* add all the properties from a game object to the Game Item model */
	public static GameItem GameObjectToGameItem(GameObject gameObject)
	{
		/* we found a gameobject that doesn't have a prefab */
		if (EditorUtility.GetPrefabParent (gameObject) == null)
			return null;
		GameItem gameItem = new GameItem ();
		gameItem.name = EditorUtility.GetPrefabParent(gameObject).name;
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
		foreach (GameObject gameObject in gameObjects) {
			/* if we want to ignore this kind of object skip adding */
			if (gameObject.tag == ignoreTag)
				continue;
			/* if the gameitem is null, probably there is no prefab for the game object*/
			GameItem gameItem = GameObjectToGameItem (gameObject);
			if (gameItem != null) {
				gameItems.Add (gameItem);
			}
		}

		return gameItems.ToArray();
	}
}
