using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController3 : MonoBehaviour {

	public GameObject TrafficConePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
}
