using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
public class Accelerator : MonoBehaviour {

	// Use this for initialization
	public InputField com1;
	//public  string a=com1.text.ToString();
	public float carAcceleration;

	public float carBreak;
	// Use this for initialization
	float speed;
	float break1;
	SerialPort com=new SerialPort("COM3",9600);
	void Start () {
		


		//print (com1.text.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
			if (!com.IsOpen)
				com.Open ();
		//string[] value = com.ReadLine ().Split (',');
			
			speed = float.Parse (com.ReadLine());
		//break1 = float.Parse (value [0]);
		//speed = float.Parse (value[1]);
			carAcceleration = speed / 100;
		//carBreak = break1 / 100;

	}
}
