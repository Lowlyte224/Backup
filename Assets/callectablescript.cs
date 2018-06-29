using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callectablescript : MonoBehaviour {

    public int points;
    HUD_Manager hudmanager;

    // Use this for initialization
    void Start () {
        hudmanager = GameObject.FindGameObjectWithTag("Player").GetComponent<HUD_Manager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            gameObject.SetActive(false);
            hudmanager.UpdateScore(points);
        }

    }
}

