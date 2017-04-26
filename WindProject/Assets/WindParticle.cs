using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// wind
/// </summary>
public class WindParticle : MonoBehaviour {
    public float windParticlePower;
    public Vector3 vector;
    public float speed;
	// Use this for initialization
	void Start () {
        GetComponent<AreaEffector2D>().forceAngle = Vector2.Angle(Vector2.right, vector) * -1;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(vector*speed * Time.deltaTime);
        GetComponent<AreaEffector2D>().forceMagnitude = windParticlePower;
        
	}
}
