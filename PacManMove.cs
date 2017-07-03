using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PacManMove : MonoBehaviour {

    bool pause = false;
	public AudioSource comida;
	public AudioSource superComida;


	[SerializeField]
	int pontos;

	// Use this for initialization
	void Start () {
        if (pause == false)
            Time.timeScale = 1;

        if (pause == true)
            Time.timeScale = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += new Vector3(0,0, -1 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);

		if (Input.GetKeyUp (KeyCode.R))
			SceneManager.LoadScene ("pacMan");


		if (pontos >= 2170)
			SceneManager.LoadScene ("SegundaFase");

	}

	void OnCollisionEnter (Collision outro)
	{
		if (outro.gameObject.tag == "Comida") 
		{
			pontos += 10;
			comida.Play ();
		}

		if (outro.gameObject.tag == "SuperComida")
		{
			pontos += 50;
			superComida.Play ();
		}
		
	}


		

}
