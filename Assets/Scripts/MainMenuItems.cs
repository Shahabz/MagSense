using UnityEngine;
using System.Collections;

public class MainMenuItems : MonoBehaviour {
//	public GameObject GameObjToDisable;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts01 = GameObjToDisable.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts01)
//			{
//				script.enabled = false;
//			}
				Application.Quit ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts01 = GameObjToDisable.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts01)
//			{
//				script.enabled = false;
//			}
			Application.LoadLevel (Application.loadedLevelName);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts01 = GameObjToDisable.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts01)
//			{
//				script.enabled = false;
//			}
			Application.LoadLevel ("TransitScene");
		}
	}

	void QuitCommanded(){
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts01 = GameObjToDisable.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts01)
//		{
//			script.enabled = false;
//		}
		Application.Quit ();
	}

	void HomeCommanded(){
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts01 = GameObjToDisable.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts01)
//		{
//			script.enabled = false;
//		}
		Application.LoadLevel ("TransitScene");
	}
	
}
