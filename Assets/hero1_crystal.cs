using UnityEngine;
using System.Collections;

public class hero1_crystal : MonoBehaviour {

	public int maxNumber = 1;
	public int remainNumber = 1;

	public UISprite[] crystals;

	private int totalNumber;
	private UILabel label;

	void Awake(){
		totalNumber = crystals.Length;
		label = this.GetComponent<UILabel> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		UpdateShow ();//test
	}

	public void UpdateShow(){
		for (int i = maxNumber; i < totalNumber; i++) {
			crystals[i].gameObject.SetActive(false);
		}
		for (int i = 0; i < maxNumber; i++) {
			crystals[i].gameObject.SetActive(true);
		}
		for (int i = remainNumber; i < maxNumber; i++) {
			crystals[i].spriteName = "TextInlineImages_normal";
		}
		for (int i = 0; i<remainNumber; i++) {
			int numberName = i + 1;
			string tempStr = "";
			if(numberName <= 9){
				tempStr = "0" + numberName;
			}else{
				tempStr = "" + numberName;
			}

			crystals[i].spriteName = "TextInlineImages_" + tempStr;
		}

		label.text = remainNumber + "/" + maxNumber;
	}
}
