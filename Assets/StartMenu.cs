using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    public MovieTexture movTexture;

	// Use this for initialization
	void Start () {
        movTexture.loop = false;
        movTexture.Play();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnGUI() {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), movTexture);
    }
}
