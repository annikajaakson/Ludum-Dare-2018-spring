using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class quiz : MonoBehaviour {
    public List<int> valikud = new List<int>();
    // Question sprites
    public Sprite q1;
    public Sprite q2;
    public Sprite q3;
    public Sprite q4;
    public Sprite q5;
    public Sprite q6;

	// Use this for initialization
	void Start () {
        Debug.Log("Start!");
        Debug.Log(Input.mousePosition);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseDown() {
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 1.48f 
        && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > 0.487f) {
            Debug.Log("Answer 1");
            valikud.Add(1);
        }

        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0.487f
        && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -0.52f) {
            Debug.Log("Answer 2");
            valikud.Add(2);
        }

        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -0.52f
        && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -1.48f) {
            Debug.Log("Answer 3");
            valikud.Add(3);
        }

        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -1.48f
        && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -2.48f) {
            Debug.Log("Answer 4");
            valikud.Add(4);
        }

        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -2.48f
        && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -3.5f) {
            Debug.Log("Answer 5");
            valikud.Add(5);
        }
    }
}
