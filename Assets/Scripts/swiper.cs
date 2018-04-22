using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiper : MonoBehaviour
{
    public GameObject door_left;
    public GameObject door_right;
    private float speed = 0.05f;
    private bool open = false;
    private bool moving = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!open && moving)
        {
            door_right.transform.Translate(Vector3.right * speed);
            door_left.transform.Translate(Vector3.left * speed);
            if (door_right.transform.position.x > 3.5f)
            {
                open = true;
                moving = false;
            }
        }

        if (open && moving)
        {
            door_right.transform.Translate(Vector3.left * speed);
            door_left.transform.Translate(Vector3.right * speed);
            if (door_right.transform.position.x <= 1.05f)
            {
                open = false;
            }
        }
    }

    void OnMouseDown()
    {
        moving = true;
    }
}

