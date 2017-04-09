using UnityEngine;
using System.Collections;

public class objescripti : MonoBehaviour {

	// Use this for initialization

	void Start () {

	}

	void OnCollisionEnter2D ( Collision2D obje) {
		GetComponent < Rigidbody2D > ().velocity = Vector3.Reflect(GetComponent < Rigidbody2D > ().velocity, obje.transform.right)*8;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
