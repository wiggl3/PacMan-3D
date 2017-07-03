using UnityEngine;
using System.Collections;

public class Pontuação : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision outro)
	{
		if (outro.gameObject.tag == "Player") 
		{
			Destroy (gameObject);
		}			
	}
}
