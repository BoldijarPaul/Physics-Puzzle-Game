using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		/* other thing touched our ball. if is the bomb, delete it. */
		if (other.gameObject.tag == "Launcher Bomb") {
			other.gameObject.GetComponent<Collider2D>().isTrigger=true;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
