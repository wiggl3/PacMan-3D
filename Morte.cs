using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Morte : MonoBehaviour {

	public AudioSource fundo;
    bool pause = true;
	public Text inicio;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (pause == true)
        {
            Time.timeScale = 0;

			if (Input.GetKey(KeyCode.P)) 
			{
				pause = false;
			}
			fundo.Play ();

			inicio.text = "Press P for Play";
        }

		if (pause == false) 
		{
			Time.timeScale = 1;
			inicio.text = "";
		}
	}

    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.tag == "Fantasma")
        {
            //Destroy(gameObject);
            pause = true;
        }
    }
}
