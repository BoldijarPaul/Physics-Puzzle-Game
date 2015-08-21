using UnityEngine;
using System.Collections;

public class UIManager  {

	private static GameObject WhiteBackground;
	private static GameObject GameOverPanel;
	
	public static void Load()
	{
		WhiteBackground=GameObject.Find ("White Background");
		GameOverPanel=GameObject.Find ("Game Over Panel");
		ShowLevelClearedMenu (false);
		
	}

	public static void ShowLevelClearedMenu(bool show)
	{
		GameOverPanel.SetActive (show);
		WhiteBackground.SetActive (show);
	}
}
