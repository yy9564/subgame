using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour {
    public GameObject bamsongi;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(bamsongi) as GameObject ;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            go.GetComponent<bamsongiControl>().Shoot(worldDir.normalized * 2000);
        }
	}
}
