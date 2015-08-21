using UnityEngine;
using System.Collections;

public class UIManager  {


	public static void ShowLevelClearedMenu(bool show)
	{
		GameObject.Find ("White Background").SetActive (show);
		GameObject.Find ("Game Over Panel").SetActive (show);
	}
}
