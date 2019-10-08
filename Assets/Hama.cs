using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hama : MonoBehaviour {
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

	private void OnMouseDown(){
		Destroy(this.gameObject);
	}
    // Update is called once per frame
    void Update () {
    }
    void OnTriggerEnter2D(Collider2D other){ 
            if (other.tag == "sideDetector"){
                Debug.Log("disamping");
            }      
            Debug.Log(other.tag);
            Destroy(gameObject);
        
    }
}