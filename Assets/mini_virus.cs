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
        x = -1*Mathf.Cos(3.14f);
        y = Mathf.Sin(3.14f);
    }
	
	// Update is called once per frame
	void Update () {
		if (lifetime < 0)
        {
            Destroy(this.gameObject);
        }
        lifetime -= Time.deltaTime;

        transform.position += new Vector3(x,y,0);
	}
}
