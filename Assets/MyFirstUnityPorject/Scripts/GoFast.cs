using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoFast : MonoBehaviour {
    public float FSpeed = 5.2f;
    public int TotalCoins = 0;
    private AudioSource audioData;


    // Use this for initialization
    void Start () {
        audioData = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        moveObject();

    }


    private void moveObject()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * FSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * -FSpeed);
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


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("entered");
        audioData.Play();
        TotalCoins = TotalCoins + 1;
        Debug.Log("Total Coins: " + TotalCoins);
        Destroy(other.gameObject);
    }
}
