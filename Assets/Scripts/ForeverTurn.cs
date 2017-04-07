using UnityEngine;
using System.Collections;

public class ForeverTurn : MonoBehaviour {
	public bool TurnX = false;
	public bool TurnY = true;
	public bool TurnZ = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (TurnX) {
			transform.Rotate (-(6 * 10 * Time.deltaTime), 0, 0);
		}
		if (TurnY) {
			transform.Rotate (0, -(6 * 10 * Time.deltaTime), 0);
		}
		if (TurnZ) {
			transform.Rotate (0, 0, -(6 * 10 * Time.deltaTime));
		}
	}
}
