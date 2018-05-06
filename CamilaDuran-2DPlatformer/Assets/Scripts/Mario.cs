using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mario : MonoBehaviour {

	private int count; 
	private int counthearts;
	private int countstars;
	public Text countText; 
	public Text countTexthearts;
	public Text countTextstars;

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.CompareTag("Coin")) {
			count = count + 1;
			SetCountText ();
		}
		if (collider.gameObject.CompareTag("Star")) {
			countstars = countstars + 1;
			SetCountTextStars ();
		}
		if (collider.gameObject.CompareTag("Heart")) {
			counthearts = counthearts + 1;
			SetCountTextHearts ();
		}
	}

	// Use this for initialization
	void Start () {
		count = 0; 
		SetCountText ();
		countstars = 0;
		SetCountTextStars ();
		counthearts = 0;
		SetCountTextHearts ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate (-0.05f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.05f, 0f, 0f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			this.transform.Translate (0f, 0.5f, 0f);
		}
	}

	void SetCountText () {
		countText.text = "0" + count.ToString ();
	}

	void SetCountTextStars () {
		countTextstars.text = "0" + countstars.ToString ();
	}

	void SetCountTextHearts () {
		countTexthearts.text = "0" + counthearts.ToString ();
	}
}
