using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnMouseDown(){
		Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Buah Diserang Hama");
		Destroy(gameObject);
	}
}
