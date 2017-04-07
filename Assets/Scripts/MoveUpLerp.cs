using UnityEngine;
using System.Collections;

public class MoveUpLerp : MonoBehaviour {
	public Transform startMarker;
	public Transform endMarker;
	public float speed = 0.05F;
	private float startTime;
	private float journeyLength;
	public Transform target;
	public float smooth = 5.0F;
	private bool isMoveUp = false;

	void Start() {
		startTime = Time.time;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

		GameObject moveRocket01 = GameObject.Find ("MainGUI");
		moveRocket01.GetComponent<LaunchItem> ().moveRocket += delegate(object sender) {
			StartCoroutine(waitAndMove());
		};
	}

	void Update() {
		if (isMoveUp) {
						float distCovered = (Time.time - startTime) * speed;
						float fracJourney = distCovered / journeyLength;
						transform.position = Vector3.Lerp (startMarker.position, endMarker.position, fracJourney);
				}
	}

	IEnumerator waitAndMove(){
		yield return new WaitForSeconds (6.0f);
		isMoveUp = true;
	}
}
