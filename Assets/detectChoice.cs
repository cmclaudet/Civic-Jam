using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectChoice : MonoBehaviour {
	// Use this for initialization
	public void onTopResponse () {
		GetComponentInParent<askQuestion>().answerGiven = true;
		GetComponentInParent<askQuestion>().answer = true;
	}

	public void onBottomResponse() {
		GetComponentInParent<askQuestion>().answerGiven = true;
		GetComponentInParent<askQuestion>().answer = false;
	}
}
