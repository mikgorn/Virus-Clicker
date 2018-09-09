using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score_script : MonoBehaviour {
    public Text label;
    public game game_script;
	// Use this for initialization
	void Start () {
        game_script = game.FindObjectOfType<game>();
        label = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        label.text = "Units:"+game_script.units;
	}
}
