using UnityEngine;
using System.Collections;
using System.Collections.Generic;	//用List

public class HistoryCard : MonoBehaviour {

	public Transform inCard, outCard, card1, card2;
	public GameObject cardPrefab;

	private List<GameObject> cardList = new List<GameObject>();
	private float yOffset;

	// Use this for initialization
	void Start () {
		yOffset = card2.position.y - card1.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log("0");
			StartCoroutine( AddCard());
		}
	}

	public IEnumerator AddCard(){
		Debug.Log("0.1");

		GameObject go = GameObject.Instantiate (cardPrefab, inCard.position, Quaternion.identity) as GameObject;
		yield return 0;
		go.transform.position = inCard.position;

		Debug.Log("1");

		iTween.MoveTo (go, card1.position, 1);
		if (cardList.Count >= 6) {
			iTween.MoveTo(cardList[0],outCard.position, 1);
			Destroy(cardList[0] , 2);
			cardList.RemoveAt(0);
		}

		Debug.Log("2");

		for (int i = 0; i < cardList.Count; i++) {
			iTween.MoveTo(cardList[i], cardList[i].transform.position + new Vector3(0 , yOffset , 0),0.5f);
		}

		cardList.Add(go);
	}
}
