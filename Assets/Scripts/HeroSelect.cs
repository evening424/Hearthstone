using UnityEngine;
using System.Collections;

public class HeroSelect : MonoBehaviour {
	public int heroId = 0;
	
	private string[] heroNames = {
		"1",
		"2",
		"3",
		"4",
		"5",
		"6",
		"7",
		"8",
		"9"
	};

	private UISprite selectHeroImage;
	private UILabel selectHeroName;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Awake(){
		selectHeroImage = this.transform.parent.Find ("hero0").GetComponent<UISprite> ();
		selectHeroName = this.transform.parent.Find ("hero_name").GetComponent<UILabel> ();
	}
	
	void OnClick(){
		string heroname = this.gameObject.name;
		selectHeroImage.spriteName = heroname;
		selectHeroName.text = heroNames [heroId-1];
	}
}
