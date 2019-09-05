using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour {
	public static int level = 0;
	bool scoreIncreased; 

	private AudioSource pickupSoundSource;

	void Awake() {
		scoreIncreased = false;
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Pickup") {
			pickupSoundSource.Play();
			// Make sure the score is increased only ONCE in this call back function
			if (!scoreIncreased)
			{
				GrabPickups.level = GrabPickups.level + 1;
				scoreIncreased = true;
			}	
			
			SceneManager.LoadScene("Play");
		}
	}
}

