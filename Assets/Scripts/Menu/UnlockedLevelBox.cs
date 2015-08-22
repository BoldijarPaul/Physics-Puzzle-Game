using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnlockedLevelBox : MonoBehaviour {

 
	
	// Update is called once per frame
	void Update () {
	
	}
	public void setData(bool locked,int level)
	{
		Image image = GetComponent<RectTransform> ().GetChild (1).GetComponent<Image> ();
		Text text = GetComponent<RectTransform> ().GetChild (0).GetComponent<Text> ();
		if (locked) {
			text.text = "";
			image.color = new Color (image.color.r, image.color.g, image.color.b, 1);
		} else {
			image.color = new Color (image.color.r, image.color.g, image.color.b, 0);
			text.text = level + "";
		}

	}
}
