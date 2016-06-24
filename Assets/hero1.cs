using UnityEngine;
using System.Collections;

public class hero1 : MonoBehaviour {

	private UISprite sprite;

	// Use this for initialization
	void Start () {
		sprite = this.GetComponent<UISprite> ();
		string heroName = PlayerPrefs.GetString ("hero1");
		sprite.spriteName = heroName;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
