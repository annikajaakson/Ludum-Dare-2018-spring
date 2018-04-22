using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class quiz : MonoBehaviour {
    public List<int> valikud = new List<int>();
    public List<string> traits = new List<string>();
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
                if (spriteR.sprite == q1) {
                traits.Add("furry");
                answered = true;
                 }
                else if (spriteR.sprite == q2)
                {
                    traits.Add("shy");
                    answered = true;
                }
                else if (spriteR.sprite == q3)
                {
                    traits.Add("vegan");
                    answered = true;
                }
                else if (spriteR.sprite == q4)
                {
                    traits.Add("anti social");
                    answered = true;
                }
                else if (spriteR.sprite == q5)
                {
                    traits.Add("THOT");
                    answered = true;
                }
                else if (spriteR.sprite == q6)
                {
                    traits.Add("murderer");
                    answered = true;
                }
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0.487f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -0.52f) {
               /* Debug.Log("Answer 2");
                valikud.Add(2);
                answered = true;*/
                if (spriteR.sprite == q1)
                {
                    traits.Add("basic");
                    answered = true;
                }
                else if (spriteR.sprite == q2)
                {
                    traits.Add("romantic");
                    answered = true;
                }
                else if (spriteR.sprite == q3)
                {
                    traits.Add("dumb blonde");
                    answered = true;
                }
                else if (spriteR.sprite == q4)
                {
                    traits.Add("spineless");
                    answered = true;
                }
                else if (spriteR.sprite == q5)
                {
                    traits.Add("gay");
                    answered = true;
                }
                else if (spriteR.sprite == q6)
                {
                    traits.Add("capitalist");
                    answered = true;
                }
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -0.52f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -1.48f) {
               /* Debug.Log("Answer 3");
                valikud.Add(3);
                answered = true;*/
                if (spriteR.sprite == q1)
                {
                    traits.Add("edgy fat");
                    answered = true;
                }
                else if (spriteR.sprite == q2)
                {
                    traits.Add("asexual");
                    answered = true;
                }
                else if (spriteR.sprite == q3)
                {
                    traits.Add("cannibal");
                    answered = true;
                }
                else if (spriteR.sprite == q4)
                {
                    traits.Add("skinhead");
                    answered = true;
                }
                else if (spriteR.sprite == q5)
                {
                    traits.Add("desperate");
                    answered = true;
                }
                else if (spriteR.sprite == q6)
                {
                    traits.Add("mentally challenged");
                    answered = true;
                }
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -1.48f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -2.48f) {
                /*Debug.Log("Answer 4");
                valikud.Add(4);
                answered = true;*/
                if (spriteR.sprite == q1)
                {
                    traits.Add("nerd");
                    answered = true;
                }
                else if (spriteR.sprite == q2)
                {
                    traits.Add("dtf");
                    answered = true;
                }
                else if (spriteR.sprite == q3)
                {
                    traits.Add("thirsty");
                    answered = true;
                }
                else if (spriteR.sprite == q4)
                {
                    traits.Add("santa");
                    answered = true;
                }
                else if (spriteR.sprite == q5)
                {
                    traits.Add("crackhead");
                    answered = true;
                }
                else if (spriteR.sprite == q6)
                {
                    traits.Add("bitter");
                    answered = true;
                }
            }

            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -2.48f
            && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -3.5f) {
               // Debug.Log("Answer 5");
                valikud.Add(5);
                //answered = true;
                if (spriteR.sprite == q1)
                {
                    traits.Add("paranoid");
                    answered = true;
                }
                else if (spriteR.sprite == q2)
                {
                    traits.Add("into children");
                    answered = true;
                }
                else if (spriteR.sprite == q3)
                {
                    traits.Add("HIV");
                    answered = true;
                }
                else if (spriteR.sprite == q4)
                {
                    traits.Add("thicc");
                    answered = true;
                }
                else if (spriteR.sprite == q5)
                {
                    traits.Add("hipster");
                    answered = true;
                }
                else if (spriteR.sprite == q6)
                {
                    traits.Add("jew");
                    answered = true;
                }
            }

            if (answered) {
                if (sprite_index < 6) {
                    Debug.Log(traits[sprite_index-1]);
                    sprite_index++;
                } else {
                    spriteR.enabled = false;
                    SceneManager.LoadScene("lift_scene");
                }
            }

            Debug.Log(spriteR.sprite);
            Debug.Log(sprite_index);
            spriteR.sprite = sprites[sprite_index - 2];
        }
    }
}
