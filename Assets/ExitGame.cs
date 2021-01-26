using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {
	public GameObject Panel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void exitGame(){
		Application.Quit ();
	}
}
