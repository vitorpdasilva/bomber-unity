using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	public float speed = 100f;
	private float minX = -2.55f;
	private float maxX = 2.55f;
    
    // Update is called once per frame
    void Update() {
		movePlayer();   		
    }

    void movePlayer() {
    	float h = Input.GetAxis("Horizontal");
    	Vector2 currentPosition = transform.position;

    	if (h > 0) {
				currentPosition.x += speed * Time.deltaTime;
				
    	} else if (h < 0) {
    		currentPosition.x -= speed * Time.deltaTime;
    	}

			if (currentPosition.x < minX) {
				currentPosition.x = minX;
			}

			if (currentPosition.x > maxX) {
				currentPosition.x = maxX;
			}

			transform.position = currentPosition;
    }
		
		void OnTriggerEnter2D(Collider2D target) {
			if (target.tag == "bomb") {
				Time.timeScale = 0f;
			}
		}
}
