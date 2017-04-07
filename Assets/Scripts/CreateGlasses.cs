using UnityEngine;
using System.Collections;

public class CreateGlasses : MonoBehaviour {
	public GameObject BlueGlasses;
	public GameObject GreenGlasses;
	public GameObject RedGlasses;
	private GameObject glassClone;
	// Use this for initialization
	void Start () {

		GameObject redGlasses = GameObject.Find ("RedGlassesItem");
		redGlasses.GetComponent<ChooseGlasses>().createRedGlasses+= delegate(object sender) {
			Destroy(glassClone);
			//instantiate glasses after selection by user, add this as child to current obj's parent
			glassClone = Instantiate (RedGlasses, transform.position, transform.rotation) as GameObject;
			glassClone.transform.parent = transform.parent;
		};

		GameObject greenGlasses = GameObject.Find ("GreenGlassesItem");
		greenGlasses.GetComponent<ChooseGlasses>().createGreenGlasses+= delegate(object sender) {
			Destroy(glassClone);
			//instantiate glasses after selection by user, add this as child to current obj's parent
			glassClone = Instantiate (GreenGlasses, transform.position, transform.rotation) as GameObject;
			glassClone.transform.parent = transform.parent;
		};

		GameObject blueGlasses = GameObject.Find ("BlueGlassesItem");
		blueGlasses.GetComponent<ChooseGlasses>().createBlueGlasses+= delegate(object sender) {
			Destroy(glassClone);
			//instantiate glasses after selection by user, add this as child to current obj's parent
			glassClone = Instantiate (BlueGlasses, transform.position, transform.rotation) as GameObject;
			glassClone.transform.parent = transform.parent;
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void destroyGlasses(){
		Destroy (glassClone);
	}

	void RedCommanded(){
		Destroy(glassClone);
		//instantiate glasses after selection by user, add this as child to current obj's parent
		glassClone = Instantiate (RedGlasses, transform.position, transform.rotation) as GameObject;
		glassClone.transform.parent = transform.parent;
	}

	void BlueCommanded(){
		Destroy(glassClone);
		//instantiate glasses after selection by user, add this as child to current obj's parent
		glassClone = Instantiate (BlueGlasses, transform.position, transform.rotation) as GameObject;
		glassClone.transform.parent = transform.parent;
	}

	void GreenCommanded(){
		Destroy(glassClone);
		//instantiate glasses after selection by user, add this as child to current obj's parent
		glassClone = Instantiate (GreenGlasses, transform.position, transform.rotation) as GameObject;
		glassClone.transform.parent = transform.parent;
	}
}
