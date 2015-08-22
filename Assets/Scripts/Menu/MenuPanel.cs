using UnityEngine;
using System.Collections;

public class MenuPanel : MonoBehaviour {


	void Start () {
	
		GameObject levelBox=Resources.Load<GameObject> ("Prefabs/Level Box");

		int y = 0;
		for (int i=1; i<=10; i++) {
			GameObject a = (GameObject)Instantiate (levelBox); 
			a.transform.SetParent (transform, false);
			RectTransform rectTransform=a.GetComponent<RectTransform>();
			 
			rectTransform.anchoredPosition=new Vector2(0,y);
			y-=300;


			if(Random.Range(-10,10)<0)
			{
				a.GetComponent<UnlockedLevelBox>().setData(false,Random.Range(1,99));
			}
			else
			{
				a.GetComponent<UnlockedLevelBox>().setData(true,0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
