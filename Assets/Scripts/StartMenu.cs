using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    public MovieTexture movTexture;

	public bool isDrawMov = true;

	public TweenScale logoTween;

	// Use this for initialization
	void Start () {
        movTexture.loop = false;
        movTexture.Play();
    }

    // Update is called once per frame
    void Update () {
		if (isDrawMov) {
			if(Input.GetMouseButton(0)){
				StopMov();
			}
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
}
