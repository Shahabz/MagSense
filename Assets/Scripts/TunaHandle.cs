using UnityEngine;
using System.Collections;

public class TunaHandle : MonoBehaviour {
	public GameObject tunaPrefab;
	public GameObject tunaParent;
	private GameObject tunaClone;

	public GameObject whalePrefab;
	private GameObject whaleClone;
	// Use this for initialization
	void Start () {
		StopAllCoroutines ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(){
		transform.localScale = new Vector3 (transform.localScale.x + 5,
		                                    transform.localScale.y + 5,
		                                    transform.localScale.z);
		tunaClone = Instantiate (tunaPrefab, tunaParent.transform.position, tunaPrefab.transform.rotation) as GameObject;
		tunaClone.transform.parent = tunaParent.transform;
		tunaClone.AddComponent<Collider>();
		tunaClone.AddComponent<Rigidbody> ();
		tunaClone.rigidbody.AddForce (Physics.gravity * 1.5f);
		gameObject.renderer.enabled = false;
		gameObject.collider.enabled = false;
		StartCoroutine (controlTunaIcon ());
	}

	void OnCollisionExit(){
		transform.localScale = new Vector3 (transform.localScale.x - 5,
		                                    transform.localScale.y - 5,
		                                    transform.localScale.z);
	}

	IEnumerator controlTunaIcon(){
		yield return new WaitForSeconds (3.5f);
		whaleClone = Instantiate (whalePrefab, whalePrefab.transform.position, 
		                         whalePrefab.transform.rotation) as GameObject;
		yield return new WaitForSeconds (7.0f);
		Destroy (tunaClone);
		Destroy (whaleClone);
		gameObject.renderer.enabled = true;
		gameObject.collider.enabled = true;
	}
}
