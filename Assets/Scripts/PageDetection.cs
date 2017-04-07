using UnityEngine;
using System.Collections;

public class PageDetection : MonoBehaviour {

	public GameObject magText;
	private bool isPageThere = false;
	private bool isRoutineRunning = false;

	// Use this for initialization
	void Start () {
		StopAllCoroutines ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PageDetected(){
		print ("PageDetection:: Inside PageDetected");
		isPageThere = true;
		magText.SetActive (true);
	}
	
	void PageLost(){
		print ("PageDetection:: Inside PageLost");
		if (!isRoutineRunning) {
			isPageThere = false;
			StartCoroutine (CheckPage ());
		}
	}

	IEnumerator CheckPage(){
		isRoutineRunning = true;
		print ("PageDetection:: Inside CheckPage");
		yield return new WaitForSeconds(3.0f);
		if (!isPageThere) {
			magText.SetActive(false);
			Application.LoadLevel("TransitScene");
		}
		isRoutineRunning = false;
	}
}