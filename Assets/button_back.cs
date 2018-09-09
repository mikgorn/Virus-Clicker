using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button_back : MonoBehaviour {

    private Button btn;

    public GameObject infect_panel;
    public GameObject evolve_panel;
    public GameObject main_panel;


    // Use this for initialization
    void Start () {
        btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(go_back);
	}
	
    void go_back()
    {
        evolve_panel.SetActive(false);
        infect_panel.SetActive(false);
        main_panel.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
