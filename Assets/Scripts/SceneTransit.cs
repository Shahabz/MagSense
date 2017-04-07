using UnityEngine;
using System.Collections;

public class SceneTransit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StopAllCoroutines ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TransitToScene01(){
		print ("Inside TransitToScene01");
		Application.LoadLevel("CoverPageScene");
	}

	void TransitToScene02(){
		print ("Inside TransitToScene01");
		Application.LoadLevel("EyeGlassesScene");
	}

	void TransitToScene03(){
		print ("Inside TransitToScene01");
		Application.LoadLevel("SeaWorldScene");
	}

	void TransitToScene04(){
		print ("Inside TransitToScene01");
		Application.LoadLevel("RocketLaunchScene");
	}
}
