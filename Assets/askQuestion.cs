using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class askQuestion : MonoBehaviour {

	public string[] startLines;
	public string[] responses1;
	public string[] responses2;
	public GameObject choiceText;
	private int currentLine;
	private int totalLines;
	private string[] activeLines;
	public bool questionAsked{get;set;}
	public bool answerGiven{get;set;}
	//if answer is true player has chosen top dialogue option
	public bool answer{get;set;}

	// Use this for initialization
	void Start () {
		currentLine = 1;
		activeLines = startLines;
		totalLines = activeLines.Length;
		questionAsked = false;
		GetComponent<Text>().text = activeLines[currentLine - 1];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			//if space is pressed next line is printed
			if (currentLine < totalLines) {
				GetComponent<Text>().text = activeLines[currentLine];
				currentLine += 1;
			//if on last line already choice is activated if question has not been asked
			} else {
				if (!questionAsked) {
					choiceText.gameObject.SetActive(true);
				//if question has been asked dialogue must be done
				} else {
					gameObject.SetActive(false);
				}
			}
		}

		//answer given is triggered by pressing buttons on choice dialogue
		if (answerGiven) {
			questionAsked = true;
			//answer is true is player clicks top response
			if (answer) {
				currentLine = 1;
				activeLines = responses1;
				totalLines = activeLines.Length;
				GetComponent<Text>().text = activeLines[currentLine - 1];
			} else {
				currentLine = 1;
				activeLines = responses2;
				totalLines = activeLines.Length;
				GetComponent<Text>().text = activeLines[currentLine - 1];
			}
			//set to false again so dialogue is reset just once
			answerGiven = false;
		}
		
	}
}
