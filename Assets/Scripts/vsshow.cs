﻿using UnityEngine;
using System.Collections;

public class vsshow : MonoBehaviour {

	public static vsshow _instance;
	void Awake(){
		_instance = this;
		this.gameObject.SetActive (false);
	}

	public TweenScale vsTween;
	public TweenPosition hero1Tween;
	public TweenPosition hero2Tween;

	// Use this for initialization
	void Start () {
		//Show("hero1", "hero2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Show(string hero1Name , string hero2Name){
		PlayerPrefs.SetString ("hero1", hero1Name);
		PlayerPrefs.SetString ("hero2", hero2Name);

		Blankmask._instance.Show ();

		this.gameObject.SetActive (true);

		hero1Tween.GetComponent<UISprite> ().spriteName = hero1Name;
		hero2Tween.GetComponent<UISprite> ().spriteName = hero2Name;

		vsTween.PlayForward ();
		hero1Tween.PlayForward ();
		hero2Tween.PlayForward ();
	}
}
