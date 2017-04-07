using UnityEngine;
using System.Collections;

public class FaceTrack : MonoBehaviour {

	private bool isFaceThere = false;
	private bool isRoutineRunning = false;
	
	// Use this for initialization
	void Start () {
		StopAllCoroutines ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FaceDetected(){
		print ("PageDetection:: Inside PageDetected");
		isFaceThere = true;
	}
	
	void FaceLost(){
		print ("PageDetection:: Inside PageLost");
		if (!isRoutineRunning) {
			isFaceThere = false;
			StartCoroutine (CheckPage ());
		}
	}
	
	IEnumerator CheckPage(){
		isRoutineRunning = true;
		print ("PageDetection:: Inside CheckPage");
		yield return new WaitForSeconds(4.0f);
		if (!isFaceThere) {
			Application.LoadLevel("TransitScene");
		}
		isRoutineRunning = false;
	}
}