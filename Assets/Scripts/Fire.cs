using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject bullet;
   // public Transform firePoint;
    public float fireSpeed = 10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject clone; 
            clone = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(transform.forward * fireSpeed);
            Destroy(clone, 5f);
        }
	}
}
