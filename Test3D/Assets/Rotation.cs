using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public float speed = 5;
    private int i = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) && i > 0)
        {
            Left();
        }
        if(Input.GetMouseButton(0)&& i < 0)
        {
            Right();
        }
	}
    public void Left() {
        i = 1;
        transform.Rotate(0, -speed, 0);
    }
    public void Right()
    {
        i = -1;
        transform.Rotate(0, +speed, 0);
    }
}
