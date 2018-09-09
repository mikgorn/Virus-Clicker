using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class amount_script : MonoBehaviour {
    public Text label;
	// Use this for initialization
	void Start () {
        label = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        int n = GameObject.FindGameObjectsWithTag(this.gameObject.transform.parent.tag).Length-1;
        label.text = n.ToString();
	}
}
