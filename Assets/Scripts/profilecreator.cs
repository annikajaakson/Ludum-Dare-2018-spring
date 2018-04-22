using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profilecreator : MonoBehaviour {
    public Sprite pic1;
    public Sprite pic2;
    public Sprite pic3;
    public Sprite pic4;
    public Sprite pic5;
    public Sprite pic6;
    public Sprite pic7;
    public Sprite pic8;
    public Sprite pic9;
    public Sprite pic10;
    public Sprite pic11;
    private List<Sprite> pildid = new List<Sprite>();
    public GameObject question;
    public Sprite player;
    private int spriter;
    public int age;
    private List<string> nimed = new List<string>();
    private int namer;
    public string Name;
    public Text nname;
    public Text description;
    // Use this for initialization
    void Start () {
        age = Random.Range(0, 100);
        spriter = Random.Range(0, 11);
        namer = Random.Range(0, 31);
        pildid.Add(pic1);
        pildid.Add(pic2);
        pildid.Add(pic3);
        pildid.Add(pic4);
        pildid.Add(pic5);
        pildid.Add(pic6);
        pildid.Add(pic7);
        pildid.Add(pic8);
        pildid.Add(pic9);
        pildid.Add(pic10);
        pildid.Add(pic11);
        player = pildid[spriter];
        nimed.Add("Doris");
        nimed.Add("Kristina");
        nimed.Add("Karin");
        nimed.Add("Annika");
        nimed.Add("Gaius Valerius");
        nimed.Add("Gamil");
        nimed.Add("Kalajanar");
        nimed.Add("Mortimer");
        nimed.Add("Heinrich");
        nimed.Add("Hugo");
        nimed.Add("Harald");
        nimed.Add("Prudencia");
        nimed.Add("Siegfried");
        nimed.Add("Tillmann");
        nimed.Add("Benedict");
        nimed.Add("Fabian");
        nimed.Add("Marvin");
        nimed.Add("Caecilius");
        nimed.Add("Grumio");
        nimed.Add("Maya");
        nimed.Add("Mia");
        nimed.Add("Miles");
        nimed.Add("Manfred");
        nimed.Add("Paula");
        nimed.Add("Wilhelmina");
        nimed.Add("Marjorie");
        nimed.Add("Maude");
        nimed.Add("Seymour");
        nimed.Add("Agnes");
        nimed.Add("Gary");
        nimed.Add("Franziska");
        Name = nimed[namer];
        this.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = player;
        nname.text = Name + " " + age;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void describe()
    {
        string best = "*" + question.gameObject.GetComponent<quiz>().traits[0] + "\n" + "*" + question.gameObject.GetComponent<quiz>().traits[1] + "\n" + "*" + question.gameObject.GetComponent<quiz>().traits[2] + "\n" + "*" + question.gameObject.GetComponent<quiz>().traits[3] +"\n"+"*" + question.gameObject.GetComponent<quiz>().traits[4] + "\n" + "*" + question.gameObject.GetComponent<quiz>().traits[5];
       // description.text = "*" + question.gameObject.GetComponent<quiz>().traits[0]
        description.text = best.Replace("<br>", "\n");
        nname.gameObject.SetActive(true);
    }
}
