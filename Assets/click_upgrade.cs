using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class click_upgrade : MonoBehaviour {
    ulong[] price = {50, 1000, 20000, 3000000, 10000000000 };
    ulong[] inc = { 2, 5, 10, 20, 3 };
    ulong cur_price;
    ulong cur_inc;
    int i;

    public Text price_label;
    public Text inc_label;
    public Text i_label;

    Button upgrade_button;
    game game_script;
    
	// Use this for initialization
	void Start () {
        game_script = GameObject.FindObjectOfType<game>();
        upgrade_button = this.gameObject.GetComponent<Button>();
        upgrade_button.onClick.AddListener(upgrade);
        cur_inc = inc[0];
        cur_price = price[0];
        i = 0;
        price_label.text = cur_price.ToString();
        inc_label.text = ((cur_inc-1) *100).ToString();
        i_label.text = "0";
	}

    void upgrade()
    {
        if (game_script.units >= cur_price)
        {
            game_script.units -= cur_price;
            game_script.click_income  = game_script.click_income*cur_inc;
            i++;
            if (i < 5)
            {
                cur_inc = inc[i];
                cur_price = price[i];
                price_label.text = cur_price.ToString();
                inc_label.text = ((cur_inc - 1) * 100).ToString();
                i_label.text = i.ToString();

            }
            else
            {
                cur_price = cur_price * 2;
                price_label.text = cur_price.ToString();
                inc_label.text = ((cur_inc - 1) * 100).ToString();
                i_label.text = i.ToString();
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
