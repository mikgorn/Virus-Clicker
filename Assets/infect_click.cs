using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infect_click : MonoBehaviour {
    public ulong price;
    public float lifetime;
    public float income;
    public string tag;
    public GameObject infected_prefab;
    private Button infect_button;

    public game game_script;
    public Text income_label;
        
	// Use this for initialization
	void Start () {
        game_script = game.FindObjectOfType<game>();
        infect_button = this.gameObject.GetComponent<Button>();
        infect_button.onClick.AddListener(infect);
	}

    void infect()
    {
        if (game_script.units >= price)
        {
            game_script.units -= price;
            GameObject new_infected = Instantiate(infected_prefab, this.gameObject.transform.parent.parent);
            new_infected.tag = this.gameObject.tag;
            infected infected_script = new_infected.GetComponent<infected>();
            infected_script.lifetime = lifetime;
            infected_script.income = income;
            infected_script.start_counting();
        }
        else
        {
        }
    }
	// Update is called once per frame
	void Update () {
        income_label.text = (income*10).ToString() ;
	}
}
