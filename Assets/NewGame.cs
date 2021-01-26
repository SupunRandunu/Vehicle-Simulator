using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewGame : MonoBehaviour {
	public Transform canvas;
	// Use this for initialization
	public GameObject Panel;
	// Use this for initialization
	public void newGame(){
		//Application.LoadLevel (x);
		//Panel.gameObject.SetActive(false);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Time.timeScale = 1f;
			canvas.gameObject.SetActive (false);

	}
}
