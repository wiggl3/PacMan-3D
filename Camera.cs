using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Camera : MonoBehaviour {

	public Transform cameraPos;
	public Vector3 posicaoCamera;

	// Use this for initialization
	void Start () {
		transform.position = cameraPos.position;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
