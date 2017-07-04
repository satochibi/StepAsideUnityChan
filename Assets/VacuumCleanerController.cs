using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumCleanerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag" || 
            other.gameObject.tag == "TrafficConeTag" || 
            other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
        
    }
}
