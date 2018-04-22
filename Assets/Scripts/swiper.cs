using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiper : MonoBehaviour
{
    public GameObject door_left;
    public GameObject door_right;
    public GameObject profile;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite s6;
    public Sprite s7;
    public Sprite s8;
    public Sprite s9;
    public Sprite s10;
    public Sprite s11;
    public Sprite s12;
    public Sprite s13;
    public Sprite[] sprites;
    public int sprite_index = 1;
    private SpriteRenderer spriteR;
    private float speed = 0.05f;
    private bool open = false;
    private bool moving = false;
    public List<profiil> profiilid = new List<profiil>();
    public List<List<string>> likes = new List<List<string>>();
    public List<List<string>> dlikes = new List<List<string>>();

    public class profiil
    {
        public List<string> preferences;
        public List<string> dislikes;
        public int level;
    }

    // Use this for initialization
    void Start()
    {
        spriteR = this.profile.GetComponent<SpriteRenderer>();
        sprites = new Sprite[] {s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13};
        profiil person = new profiil();

        List<string> temp = new List<string>();

        // Women
        temp = new List<string> {"furry", "dtf", "thirsty", "skinhead", "desperate", "mentally challenged"};
        likes.Add(temp);
        temp = new List<string> { "jew"};
        dlikes.Add(temp);

        temp = new List<string> { "vegan", "thicc", "THOT", "asexual", "mentally challenged", "paranoid", "basic", "hipster"};
        likes.Add(temp);
        temp = new List<string> { "murderer"};
        dlikes.Add(temp);

        temp = new List<string> { "HIV", "THOT", "dtf", "edgy fat", "thicc", "into children"};
        likes.Add(temp);
        temp = new List<string> { "anti-social", "paranoid", "spineless", "gay"};
        dlikes.Add(temp);

        temp = new List<string> { "capitalist", "hipster"};
        likes.Add(temp);
        temp = new List<string> { "vegan", "nerd", "spineless"};
        dlikes.Add(temp);

        temp = new List<string> { "desperate", "anti-social", "crackhead", "spineless", "jew", "santa", "nerd"};
        likes.Add(temp);
        temp = new List<string> { "THOT", "gay", "thirsty"};
        dlikes.Add(temp);

        temp = new List<string> { "dtf", "desperate", "THOT"};
        likes.Add(temp);
        temp = new List<string> { "vegan", "asexual", "gay", "spineless"};
        dlikes.Add(temp);


        // Men
        temp = new List<string> { "furry", "basic", "romantic", "dtf", "thirsty", "into children", "dumb blonde", "HIV", "thicc"};
        likes.Add(temp);
        temp = new List<string> { "gay", "capitalist", "mentally challenged"};
        dlikes.Add(temp);

        temp = new List<string> { "nerd", "edgy fat", "dtf", "dumb blonde", "cannibal", "anti-social", "crackhead", "THOT", "spineless"};
        likes.Add(temp);
        temp = new List<string> { "gay", "into children", "vegan"};
        dlikes.Add(temp);

        temp = new List<string> { "furry", "thirsty", "anti-social", "desperate", "edgy fat", "shy", "nerd", "romantic", "vegan"};
        likes.Add(temp);
        temp = new List<string> { "basic", "hipster", "dumb blonde", "asexual", "thicc"};
        dlikes.Add(temp);

        temp = new List<string> { "romantic", "into children", "skinhead", "vegan", "desperate", "shy", "asexual", "paranoid", "basic"};
        likes.Add(temp);
        temp = new List<string> { "dtf", "edgy fat"};
        dlikes.Add(temp);

        temp = new List<string> { "skinhead", "dumb blonde", "mentally challenged", "HIV", "basic", "THOT", "thicc"};
        likes.Add(temp);
        temp = new List<string> { "vegan", "gay", "furry", "asexual", "edgy fat", "paranoid", "nerd", "bitter", "anti-social"};
        dlikes.Add(temp);

        //Other
        temp = new List<string> { "furry", "asexual", "cannibal", "jew"};
        likes.Add(temp);
        temp = new List<string> { "paranoid", "THOT", "vegan"};
        dlikes.Add(temp);

        temp = new List<string> { "romantic", "dtf", "HIV", "thicc", "capitalist", "gay", "spineless"};
        likes.Add(temp);
        temp = new List<string> { "paranoid", "murderer", "into children", "skinhead"};
        dlikes.Add(temp);

        for (int i = 0; i < 13; i++) {
            person.preferences = likes[i];
            person.dislikes = dlikes[i];
            if (i < 4) {
                person.level = 1;
            }
            else if (i < 7)
            {
                person.level = 2;
            }
            else if (i < 10)
            {
                person.level = 3;
            }
            else if (i < 12)
            {
                person.level = 4;
            }
            else if (i < 13)
            {
                person.level = 5;
            }
            profiilid.Add(person);
        }

        Debug.Log(profiilid);
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
            if (door_right.transform.position.x <= 0.0f)
            {
                open = false;
                if (sprite_index < 20)
                {
                    sprite_index++;
                    spriteR.sprite = sprites[sprite_index - 1];
                }
            }
        }
    }

    void OnMouseDown()
    {
        moving = true;
    }

    public void OnLike()
    {

    }
}

