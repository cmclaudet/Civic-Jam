using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchText : MonoBehaviour {

	public string[] lines;
	private int currentLine;
	private int totalLines;

	// Use this for initialization
	void Start () {
		currentLine = 1;
		totalLines = lines.Length;
		GetComponent<Text>().text = lines[currentLine - 1];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {

			if (currentLine < totalLines) {
				GetComponent<Text>().text = lines[currentLine];
				currentLine += 1;
			} else {
				currentLine = 1;
				gameObject.SetActive(false);
			}
		}
	}
}
