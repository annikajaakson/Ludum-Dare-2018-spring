using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LikeButton : MonoBehaviour {
    public GameObject loser;
    public GameObject winner;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject[] buttons;
    private int activebutton;
    public GameObject ab;
    public SpriteRenderer wsr;
    public SpriteRenderer lsr;
    bool match = false;
    bool rejection = false;

	// Use this for initialization
	void Start () {
        wsr = winner.GetComponent<SpriteRenderer>(); 
        lsr = loser.GetComponent<SpriteRenderer>();
        lsr.enabled = false;
        wsr.enabled = false;
        buttons = new GameObject[] { b1, b2, b3, b4, b5 };
        activebutton = 1;
	}

    private void Update()
    {
        if (match)
        {
            Debug.Log(activebutton);
            if (activebutton < 5)
            {
                activebutton += 1;
                ab = buttons[activebutton - 1];
                match = false;
            }
            else
            {
                wsr.enabled = true;
            }
        }

        if (rejection)
        {
            Debug.Log(activebutton);
            if (activebutton > 1)
            {
                activebutton -= 1;
                ab = buttons[activebutton - 1];
                rejection = false;
            }
            else
            {
                lsr.enabled = true;
            }
        }
    }

    private void OnMouseDown()
    {
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
            Debug.Log(rand);
            rejection = true;

        } else if (rand == 1)
        {
            Debug.Log(rand);
            match = true;
        }
    }
}
