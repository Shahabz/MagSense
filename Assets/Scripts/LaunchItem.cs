using UnityEngine;
using System.Collections;

public class LaunchItem : MonoBehaviour {
	public GUIText launchText;
	public GUIText timerText;
	private float timer = 10.0f;
	private int timerCount = 0;
	private bool init = false;
	private bool isLaunched = false;
	private bool isLaunchDone = false;

	public delegate void initiateLaunch(object sender);
	public event initiateLaunch initRocket;

	public delegate void moveRocketUp(object sender);
	public event moveRocketUp moveRocket;

	public delegate void initLaunchPad(object sender);
	public event initLaunchPad initPad;

	// Use this for initialization
	void Start () {
		launchText.text = "Waiting for Launch command..";
		launchText.color = new Color (255, 0, 0);
		timerText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (init) {
						timer -= Time.deltaTime;
						if (timer < 0) {
							timer = 0.0f;
						}
						timerCount = (int)timer % 60;
						timerText.text = "" + timerCount;
						//Launch only once in Update and at count 0
						if(timerCount == 5 && !isLaunched){
							isLaunched = true;
							//ignition On at 5 sec
							initRocket(this);
							//PadSmokeInit
							initPad(this);
							//Move the Big boy up!
							moveRocket(this);	
							launchText.text = "Ignition Start!";
						}
						if(timerCount == 0){
							launchText.text = "Lift off!";
						}
				}
	}

	void LaunchCall(){
		//wait till one launch is finished - check
		if (!isLaunchDone) {
			init = true;
		}
		launchText.color = new Color (0, 255, 0);
		launchText.text = "Launch Sequence Initiated!";
	}
}
