using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiper_right : MonoBehaviour {
    public GameObject rejection;
    private float speed = 0.05f;
    private bool open = false;
    private bool moving = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (!open && moving) {
            transform.Translate(Vector3.right * speed);
            if (transform.position.x > 3.5f) {
                open = true;
                moving = false;
            }
        }

        if (open && moving) {
            transform.Translate(Vector3.left * speed);
            if (transform.position.x <= 1.05f) {
                open = false;
                moving = false;
            }
        }

        if (Input.GetMouseButtonDown(0) && !moving) {
            moving = true;
        }
    }

    void OnMouseDown() {
        
    }
}
