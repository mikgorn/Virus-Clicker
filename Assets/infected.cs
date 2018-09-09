using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infected : MonoBehaviour {
    public double lifetime = 100;
    public float nexttime = 100;
    private bool counting = false;
    public float income;

    public GameObject main;
    private game game_script;
	// Use this for initialization
	void Start () {
        
        game_script = game.FindObjectOfType<game>();
        
	}
    public void start_counting()
    {
        nexttime = 0F;
        counting = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (lifetime <= 0)
        {
            Destroy(this.gameObject);
        }
        if (counting)
        {
            nexttime -= Time.deltaTime;
            if (nexttime <= 0)
            {
                nexttime = 0.1F;
                lifetime -= nexttime;
                game_script.units += (ulong)income;
            }
            
        }
	}
}
