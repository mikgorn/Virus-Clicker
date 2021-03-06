﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour {

    public ulong units = 0;
    public long dna = 0;
    public Text units_text;

    public Button virus_click;
    public Button infect_click;
    public Button evolve_click;

    public GameObject infect_panel;
    public GameObject evolve_panel;
    public GameObject main_panel;

    public GameObject virus_mini;

    public ulong click_income = 1;

	// Use this for initialization
	void Start () {
        virus_click.onClick.AddListener(virus_clicked);
        infect_click.onClick.AddListener(infect_clicked);
        evolve_click.onClick.AddListener(evolve_clicked);
	}

    void virus_clicked()
    {

        Instantiate(virus_mini);
        units += click_income;
    }
    void infect_clicked()
    {
        infect_panel.SetActive(true);
        main_panel.SetActive(false);
        evolve_panel.SetActive(false);
    }
    void evolve_clicked()
    {
        evolve_panel.SetActive(true);
        main_panel.SetActive(false);
        infect_panel.SetActive(false);

    }
    // Update is called once per frame
    void Update () {


	}
}
