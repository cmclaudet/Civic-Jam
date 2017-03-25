using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFinalChoice : MonoBehaviour {
	public GameObject phone;
	public int topChoiceNumber;
	public int bottomChoiceNumber;
	private bool selectedTopChoice;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		selectedTopChoice = phone.GetComponent<askQuestion>().answer;
		if (selectedTopChoice) {
			endGameChoice.endScene = topChoiceNumber;
		} else {
			endGameChoice.endScene = bottomChoiceNumber;
		}
	}
}
