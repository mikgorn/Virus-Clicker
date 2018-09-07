using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour {

    public ulong units = 0;
    public Text units_text;

    public Button virus_click;

	// Use this for initialization
	void Start () {
        virus_click.onClick.AddListener(virus_clicked);
	}

    void virus_clicked()
    {
        units += 1;
    }
	// Update is called once per frame
	void Update () {
        units_text.text = "Units: " + units.ToString();


	}
}
