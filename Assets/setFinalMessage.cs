using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFinalMessage : MonoBehaviour {
	public string[] end4ai1;
	public string[] end4ai2;
	public string[] end4aii1;
	public string[] end4aii2;
	public string[] end4bi1;
	public string[] end4bi2;
	public string[] end4bii1;
	public string[] end4bii2;
	private string[][] allEndText;
	private int chosenText;

	// Use this for initialization
	void Awake () {
		allEndText = new string[8][]{end4ai1, end4ai2, end4aii1, end4aii2, end4bi1, end4bi2, end4bii1, end4bii2};
		chosenText = endGameChoice.endScene;
		GetComponent<switchText>().lines = allEndText[chosenText - 1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
