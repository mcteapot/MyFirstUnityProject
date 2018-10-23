using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingPickup : MonoBehaviour {

    private AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();

        //Debug.Log("started");
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnDestroy()
    {
        audioData.Play();
        Debug.Log("Ring Destoyed");
    }
}
