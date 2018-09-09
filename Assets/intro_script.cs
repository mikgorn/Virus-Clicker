using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intro_script : MonoBehaviour {
    public AudioSource audio;
    public AudioClip intro_sound;
    public AudioClip intro1_sound;
    game game_script;
	// Use this for initialization
	void Start () {
        game_script = GameObject.FindObjectOfType<game>();
        audio = GameObject.FindObjectOfType<AudioSource>();
        audio.PlayOneShot(intro_sound);
    }
	
	// Update is called once per frame
	void Update () {

        var temp_color = this.gameObject.GetComponent<Image>().color;
       
        temp_color.a = (10f - game_script.units) / 10f;
        this.gameObject.GetComponent<Image>().color = temp_color;

        if (game_script.units >= 10)
        {
            audio.Stop();
            audio.PlayOneShot(intro1_sound);
            Destroy(this.gameObject);
        }
	}
}
