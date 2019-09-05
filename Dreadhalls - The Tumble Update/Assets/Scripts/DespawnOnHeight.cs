using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2) {
            // Stop screaming sound and reset DontDestroy instance to Null to stop the playState sound track, allowing it to restart only when we are back to a playstate
            if (DontDestroy.instance) {
                DontDestroy.instance.GetComponents<AudioSource>()[0].Stop();
                DontDestroy.instance = null;
            }
            SceneManager.LoadScene("GameOver");
        }
    }

}
