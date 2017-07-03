using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    bool pauseGame = false;
	
	// Update is called once per frame
	void Update () {

        if (pauseGame == false)
        {
            Time.timeScale = 1;
        }

        if (pauseGame == true)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.P))
        {
            if (pauseGame == false)
            {
                pauseGame = true;
            }

            if (pauseGame == true)
            {
                pauseGame = false;
            }
        }
	}
}
