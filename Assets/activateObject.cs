using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateObject : MonoBehaviour {
	public GameObject toBeActivated;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<BoxCollider2D>().OverlapPoint(new Vector2(transform.position.x, transform.position.y)) ) {
			if (Input.GetKeyDown("space")) {
				toBeActivated.gameObject.SetActive(true);
			}
		}
	}

	
}
