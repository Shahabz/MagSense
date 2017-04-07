using UnityEngine;
using System.Collections;

public class TunaDrop : MonoBehaviour {
	public delegate void tunaHandleDrop(object sender);
	public event tunaHandleDrop dropTuna;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DropTuna(){
		dropTuna (this);
	}
}
