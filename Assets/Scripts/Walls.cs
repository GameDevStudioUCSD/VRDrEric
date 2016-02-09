using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour {

	// Use this for initialization
	void Start () {
        foreach(Transform t in transform)
        {
            GameObject wall = t.gameObject;
            Rigidbody rb = wall.AddComponent<Rigidbody>();
            rb.isKinematic = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
