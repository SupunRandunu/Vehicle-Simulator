using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SetAndGetText : MonoBehaviour {
	public GameObject Panel;
	// Use this for initialization
	public void newGame(string x){
		Application.LoadLevel (x);
		//Panel.gameObject.SetActive(false);
		//SceneManager.LoadScene(x);
	
	}


}
