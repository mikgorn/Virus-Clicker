using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bacteria_upgrade : MonoBehaviour {
    public ulong[] price = { 1000, 10000, 200000, 3000000, 10000000000 };
    public ulong[] inc = { 20, 20, 10,10, 5 };
    ulong cur_price;
    ulong cur_inc;
    int i;

    public string tag;

    public Text price_label;
    public Text inc_label;
    public Text i_label;

    Button upgrade_button;
    game game_script;

    infect_click infect_script;
    // Use this for initialization
    void Start () {
        game_script = GameObject.FindObjectOfType<game>();
        infect_script = GameObject.FindGameObjectWithTag(tag).GetComponent<infect_click>();
        upgrade_button = this.gameObject.GetComponent<Button>();
        upgrade_button.onClick.AddListener(upgrade);
        cur_inc = inc[0];
        cur_price = price[0];
        i = 0;
        price_label.text = cur_price.ToString();
        inc_label.text = (cur_inc ).ToString();
        i_label.text = "0";
    }

    void upgrade()
    {
        if (game_script.units >= cur_price)
        {
            game_script.units -= cur_price;
            infect_script.income = infect_script.income * (100+cur_inc)/100;
            i++;
            if (i < 5)
            {
                cur_inc = inc[i];
                cur_price = price[i];
                price_label.text = cur_price.ToString();
                inc_label.text = (cur_inc ).ToString();
                i_label.text = i.ToString();

            }
            else
            {
                cur_price = cur_price * 2;
                price_label.text = cur_price.ToString();
                inc_label.text = (cur_inc ).ToString();
                i_label.text = i.ToString();
            }

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
