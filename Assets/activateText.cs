using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class activateText : MonoBehaviour {
	public Text toBeActivated;
	// Use this for initialization
	void Start () {
		toBeActivated.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
