using UnityEngine;
using System.Collections;

public class btnEnd : MonoBehaviour {

	private UIButton self;
	private UILabel label;

	void Awake(){
		self = this.GetComponent<UIButton> ();
		label = transform.Find ("Label").GetComponent<UILabel> ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BeClick(){
		self.SetState (UIButtonColor.State.Disabled, true);
		label.text = "对方回合";
	}
}
