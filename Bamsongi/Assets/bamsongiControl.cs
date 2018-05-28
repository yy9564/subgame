using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bamsongiControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Shoot(new Vector3(0, 200, 2000));
	}

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
