using UnityEngine;
using System.Collections;

public class ChooseGlasses : MonoBehaviour {
	private bool isSelected = false;

	public delegate void createRedGlassesInit(object sender);
	public event createRedGlassesInit createRedGlasses;

	public delegate void createBlueGlassesInit(object sender);
	public event createBlueGlassesInit createBlueGlasses;

	public delegate void createGreenGlassesInit(object sender);
	public event createGreenGlassesInit createGreenGlasses;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnCollisionEnter(){
		isSelected = true;
		transform.localScale = new Vector3 (transform.localScale.x + 0.5f,
		                                    transform.localScale.y + 0.5f,
		                                    transform.localScale.z + 0.5f);
		yield return new WaitForSeconds (1.5f);
		if(isSelected){
			if(gameObject.name == "BlueGlassesItem"){
				createBlueGlasses(this);
			}
			if(gameObject.name == "GreenGlassesItem"){
				createGreenGlasses(this);
			}
			if(gameObject.name == "RedGlassesItem"){
				createRedGlasses(this);
			}
		}
	}

	void OnCollisionExit(){
		isSelected = false;
		transform.localScale = new Vector3 (transform.localScale.x - 0.5f,
		                                    transform.localScale.y - 0.5f,
		                                    transform.localScale.z - 0.5f);
	}

}
