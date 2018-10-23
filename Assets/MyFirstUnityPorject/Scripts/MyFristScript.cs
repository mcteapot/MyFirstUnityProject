using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFristScript : MonoBehaviour {

    public int Speed = 5;
    public float FSpeed = 5.2f;
    private double gSpeed = 7.4732d;
    public string Name = "Hello World";
    public bool IsOn = false;


	// Use this for initialization
	void Start () {
        //Debug.Log("START HERE");
        moveObject();
    }
	
	// Update is called once per frame
	void Update () {
        moveObject();

    }

    private void moveObject()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * FSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -FSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * FSpeed);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -FSpeed);
        }

        //transform.Translate(Vector3.up * Time.deltaTime * FSpeed);
        //Debug.Log("UPDATE HERE");
    }
}
