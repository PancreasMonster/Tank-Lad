using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour {

    public GameObject cube;

	// Use this for initialization
	void Start () {

        for (int x = 0; x < 10; x++)
        {
          for (int y = 0; y < 5; y++)
            {
                GameObject clone;
                clone = Instantiate(cube, new Vector3(0, y * 1.2f, -3 + x * 1.25f), Quaternion.identity);
                clone.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            } 
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
