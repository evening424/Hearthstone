using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    public MovieTexture movTexture;

	public bool isDrawMov = true;

	public TweenScale logoTween;

	private bool isCanShowSelectRole = false;

	public TweenPosition selectRoleTween;

	public UISprite hero1;

	// Use this for initialization
	void Start () {
        movTexture.loop = false;
        movTexture.Play();
		logoTween.AddOnFinished (this.OnLogoTweenFinish);
    }

    // Update is called once per frame
    void Update () {
		if (isDrawMov) {
			if(Input.GetMouseButtonDown(0)){
				StopMov();
			}
		}

		if (isCanShowSelectRole && Input.GetMouseButtonDown (0)) {
			selectRoleTween.PlayForward ();
			isCanShowSelectRole = false;
		}
	}

    void OnGUI() {
		if (isDrawMov) {
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), movTexture);
		}
    }

	private void StopMov(){
		movTexture.Stop ();
		isDrawMov = false;
		//
		logoTween.PlayForward ();
	}

	private void OnLogoTweenFinish(){
		isCanShowSelectRole = true;

		//selectRoleTween.PlayForward ();
	}

	public void OnplaybtnClick(){
		Blankmask._instance.Show ();
		vsshow._instance.Show (hero1.spriteName, "hero" + Random.Range (1, 10));
		StartCoroutine (LoadPlayScreen ());
	}

	IEnumerator LoadPlayScreen(){
		yield return new WaitForSeconds (3f);
		Application.LoadLevel (1);
	}

}
