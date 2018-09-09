using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_virus : MonoBehaviour {
    public double lifetime;
    float x;
    float y;
	// Use this for initialization
	void Start () {
        var euler = transform.eulerAngles;
        euler.z = Random.Range(0, 360);
        transform.eulerAngles = euler;
        Debug.Log(euler.z);
        x = Mathf.Cos(euler.z/180);
        y = Mathf.Sin(euler.z / 180);
        if (euler.z > 180)
        {
            y *= -1;
        }
        if(euler.z>90 & euler.z < 270)
        {
            x *= -1;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (lifetime < 0)
        {
            Destroy(this.gameObject);
        }
        lifetime -= Time.deltaTime;

        transform.position += (new Vector3(x,y,0))*((float)lifetime*5);

        transform.Rotate(new Vector3(0,0,2));
    }
}
