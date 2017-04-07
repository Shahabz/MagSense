using UnityEngine;
using System.Collections;

public class LaunchRocket : MonoBehaviour {
	public GameObject TailFire;
	public GameObject TailSmoke;
	public GameObject tailFireParent;
	public GameObject tailSmokeParent;
	private GameObject tailFireClone;
	private GameObject tailSmokeClone;

	// Use this for initialization
	void Start () {
		GameObject initRocket01 = GameObject.Find ("MainGUI");
		initRocket01.GetComponent<LaunchItem>().initRocket+= delegate(object sender) {
			tailFireClone = Instantiate(TailFire, tailFireParent.transform.position,
			                            tailFireParent.transform.rotation) as GameObject;


			//set their respective parent objects so as to include them in obj tracking
			//stick the babies with mamma rocket
			//alter the tail smoke/tail fire prefab dimension to fit after cloning
			tailFireClone.transform.parent = tailFireParent.transform;
			StartCoroutine(waitAndSmokeTail());
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator waitAndSmokeTail(){
		yield return new WaitForSeconds (4.0f);
		tailSmokeClone = Instantiate(TailSmoke, tailSmokeParent.transform.position,
		                             tailSmokeParent.transform.rotation) as GameObject;
		tailSmokeClone.transform.parent = tailSmokeParent.transform;
	}
}
