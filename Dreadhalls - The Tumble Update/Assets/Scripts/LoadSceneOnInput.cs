using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	public string SceneName; // Is used to identify which Scene uses this script at the moment called

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Describe update action for the 2 scenes using this component 
		if (Input.GetAxis("Submit") == 1) {
			if (SceneName == "Title") {
				GrabPickups.level = 0;   // Reset Level every time with start a new game
				SceneManager.LoadScene("Play");
			} else if (SceneName == "GameOver") {
				SceneManager.LoadScene("Title");
			}
		}
	}
}
