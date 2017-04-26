using UnityEngine;
using System.Collections;
/// <summary>
/// Wind generator.
/// </summary>
public class WindGenerator : MonoBehaviour {
	public float windPower;
	public float windRotation;
	public float windParticleNumber;
	public GameObject windParticles;

	// Use this for initialization
	void Start () {
		StartCoroutine (WindYapan ());
	}

	IEnumerator WindYapan()
	{
		while (true) {
			yield return new WaitForSeconds(1/windParticleNumber);
			Instantiate(windParticles, transform.position+new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),0), transform.rotation);
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
