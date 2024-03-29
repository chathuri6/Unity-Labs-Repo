﻿using UnityEngine;
using System.Collections;

public class PlayerClass : MonoBehaviour {

	public float speed;
	public GameObject bombPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x > 18) {
			//get new speed
			speed = Random.Range(8f,12f);
			transform.position = new Vector3( -18f, transform.position.y, transform.position.z );
		}
		transform.Translate(0, 0, speed * Time.deltaTime);

		if (Input.anyKeyDown) {
			GameObject bombObject = (GameObject)Instantiate(bombPrefab);
			bombObject.transform.position = this.gameObject.transform.position;
		}
	
	}
}
