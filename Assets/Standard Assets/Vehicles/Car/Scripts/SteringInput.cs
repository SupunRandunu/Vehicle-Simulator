using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class SteringInput : MonoBehaviour {
	public float carRotation;
	SerialPort com1=new SerialPort("COM3",9600);
	// Use this for initialization
	float val;
	void Start () {
		

	}



	
	// Update is called once per frame
	void Update () {
		if (!com1.IsOpen)
			com1.Open ();
		val = float.Parse (com1.ReadLine());
		carRotation = val / 100;
		print ("r"+carRotation);
	}
}
