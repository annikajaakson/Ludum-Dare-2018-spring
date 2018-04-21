using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class quiz : MonoBehaviour {
    public List<int> valikud = new List<int>();
    private SpriteRenderer spriteR;

    // Question sprites
    public Sprite q1;
    public Sprite q2;
    public Sprite q3;
    public Sprite q4;
    public Sprite q5;
    public Sprite q6;

    public Sprite[] sprites;
    public int sprite_index = 1;

	// Use this for initialization
	void Start () {
        Debug.Log("Start!");
        spriteR = this.GetComponent<SpriteRenderer>();
        sprites = new Sprite[] {this.q1, this.q2, this.q3, this.q4, this.q5, this.q6};
        spriteR.sprite = sprites[sprite_index-1];
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseDown() {
        bool answered = false;

        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 4.99
        && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -4.99) {
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 1.48f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > 0.487f) {
                Debug.Log("Answer 1");
                valikud.Add(1);
                answered = true;
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0.487f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -0.52f) {
                Debug.Log("Answer 2");
                valikud.Add(2);
                answered = true;
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -0.52f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -1.48f) {
                Debug.Log("Answer 3");
                valikud.Add(3);
                answered = true;
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -1.48f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -2.48f) {
                Debug.Log("Answer 4");
                valikud.Add(4);
                answered = true;
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -2.48f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -3.5f) {
                Debug.Log("Answer 5");
                valikud.Add(5);
                answered = true;
            }

            if (answered) {
                if (sprite_index < 6) {
                    sprite_index++;
                    spriteR.sprite = sprites[sprite_index - 1];
                } else {
                    spriteR.enabled = false;
                }
            }

            Debug.Log(spriteR.sprite);
            Debug.Log(sprite_index);
        }
    }
}
