using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchText : MonoBehaviour {
	public GameObject sound;
	public GameObject objectWithText;
	public string[] lines;
	private int currentLine;
	private int totalLines;

	// Use this for initialization
	void Start () {
		currentLine = 1;
		totalLines = lines.Length;
		GetComponent<Text>().text = lines[currentLine - 1];
		playSound();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			if (currentLine < totalLines) {
				GetComponent<Text>().text = lines[currentLine];
				currentLine += 1;
			} else {
				currentLine = 1;
				inactivateObject();
				gameObject.SetActive(false);
			}
		}
	}

	void inactivateObject() {
		if (objectWithText != null) {
			objectWithText.gameObject.SetActive(false);
		}
	}

	void playSound() {
		if (sound != null) {
			AudioSource[] sounds = sound.GetComponentsInChildren<AudioSource>();
			sounds[Random.Range(0,sounds.Length)].Play();
		}
	}
}
