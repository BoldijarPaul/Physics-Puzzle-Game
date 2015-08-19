using UnityEngine;
using System.Collections;

public class XMLLoader  : MonoBehaviour{


	public static void InstantiateGameObject(GameItem gameItem)
	{
		GameObject gameObject = Resources.Load<GameObject> ("Prefabs/" + gameItem.name);
		GameObject clonedObject = (GameObject)Instantiate (gameObject, gameItem.position, Quaternion.Euler (gameItem.rotation));
		clonedObject.transform.localScale = gameItem.scale;
	}

	public static void InstantiateFromXML(string xml)
	{
		GameItem[] gameItems = XMLHelper.XmlDeserializeFromString<GameItem[]>(xml);
		foreach (GameItem gameItem in gameItems) {
			InstantiateGameObject(gameItem);
		}
	}
}
