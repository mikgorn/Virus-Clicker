using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class intro2_script : MonoBehaviour {
    public AudioSource audio;
    public AudioClip intro2_sound;
    public AudioClip intro3_sound;
    bool played = false;
    game game_script;
    // Use this for initialization
    void Start () {
        game_script = GameObject.FindObjectOfType<game>();
        audio = GameObject.FindObjectOfType<AudioSource>();
        
    }

    // Update is called once per frame
    void Update() {
        var temp_color = this.gameObject.GetComponent<Image>().color;

        temp_color.a = (50f - game_script.units) / 40f;
        this.gameObject.GetComponent<Image>().color = temp_color;

        if (game_script.units == 25 & !played)
        {
            played = true;
            audio.Stop();
            audio.PlayOneShot(intro2_sound);

        }
        if (game_script.units >= 50)
        {
            audio.Stop();
            audio.PlayOneShot(intro3_sound);
            Destroy(this.gameObject);
        }
    }
}
