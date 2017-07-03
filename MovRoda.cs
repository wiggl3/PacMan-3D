using UnityEngine;
using System.Collections;

public class MovRoda : MonoBehaviour {

    NavMeshAgent nma;
    Transform player;

    [SerializeField]
    Transform[] lugares;

    int sort;

	// Use this for initialization
	void Start () {

        nma = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sort = Random.Range (0,10);
        InvokeRepeating("Sorteio", 5f, 5f);
        nma.SetDestination (lugares[sort].position);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Sorteio()
    {
    sort = Random.Range (0,10);
        nma.SetDestination (lugares[sort].position);
    }
}
