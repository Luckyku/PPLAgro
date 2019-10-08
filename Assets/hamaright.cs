using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamaright : MonoBehaviour {
    public float speed = -10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public int Score = 0;

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

	private void OnMouseDown(){
		Destroy(this.gameObject);
        Score = Score + 5;
        Debug.Log("Score :" + Score);
	}
    // Update is called once per frame
    void Update () {
         if(transform.position.x > screenBounds.x ){
            Destroy(this.gameObject);
         }
    }
}