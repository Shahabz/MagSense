using UnityEngine;
using System.Collections;

public class LaunchPadSmoke : MonoBehaviour {
	public GameObject FireMistPrefab;
	public GameObject OuterSmokePrefab;

	public GameObject FireMistParent;
	public GameObject OuterSmokeParent01;
	public GameObject OuterSmokeParent02;
	public GameObject OuterSmokeParent03;

	private GameObject FireMistClone;
	private GameObject OuterSmokeClone01;
	private GameObject OuterSmokeClone02;
	private GameObject OuterSmokeClone03;

	// Use this for initialization
	void Start () {
		//include game obj and script which are related!!
		GameObject padInit = GameObject.Find ("MainGUI");
		print ("Inside LaunPadSmoke:: In Start");
		padInit.GetComponent<LaunchItem>().initPad+= delegate(object sender) {
			StartCoroutine(waitAndSmoke());
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator waitAndSmoke(){
		//wait and smoke up the pad
		yield return new WaitForSeconds(2.0f);
		FireMistClone = Instantiate(FireMistPrefab, FireMistParent.transform.position,
		                            FireMistParent.transform.rotation) as GameObject;
		OuterSmokeClone01 = Instantiate(OuterSmokePrefab, OuterSmokeParent01.transform.position,
		                                OuterSmokeParent01.transform.rotation) as GameObject;
		OuterSmokeClone02 = Instantiate(OuterSmokePrefab, OuterSmokeParent02.transform.position,
		                                OuterSmokeParent02.transform.rotation)as GameObject;
		OuterSmokeClone03 = Instantiate(OuterSmokePrefab, OuterSmokeParent03.transform.position,
		                                OuterSmokeParent03.transform.rotation)as GameObject;


		yield return new WaitForSeconds(5.0f);
		Destroy (FireMistClone);
		Destroy (OuterSmokeClone01);
		Destroy (OuterSmokeClone02);
		Destroy (OuterSmokeClone03);
	}
}
