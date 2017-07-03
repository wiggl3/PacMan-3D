using UnityEngine;
using System.Collections;

public class MovVermelho : MonoBehaviour {

    [SerializeField]
    Transform destino;

    NavMeshAgent nmav;
     
	// Use this for initialization
	void Start () {
        nmav = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        nmav.SetDestination(destino.position);
	}
}
