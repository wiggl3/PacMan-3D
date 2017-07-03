using UnityEngine;
using System.Collections;

public class MovLaranja : MonoBehaviour
{
    NavMeshAgent nma;
    Transform player;
    
    [SerializeField]
    Rigidbody rbplayer;

    Vector3 posFutXMais;
    Vector3 posFutXMenos;
    Vector3 posFutZMais;
    Vector3 posFutZMenos;


    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Updade()
    {
        posFutXMais = new Vector3(player.position.x + 10, player.position.y, player.position.z);
        posFutXMenos = new Vector3(player.position.x + 10, player.position.y, player.position.z);
        posFutZMais = new Vector3(player.position.x, player.position.y, player.position.z + 10);
        posFutZMenos = new Vector3(player.position.x, player.position.y, player.position.z - 10);


        if (rbplayer.velocity.x > 0)
            nma.SetDestination(posFutXMais);

        if (rbplayer.velocity.x < 0)
            nma.SetDestination(posFutXMenos);

        if (rbplayer.velocity.z > 0)
            nma.SetDestination(posFutZMais);

        if (rbplayer.velocity.x < 0)
            nma.SetDestination(posFutZMenos);
    }
    /* [SerializeField]
    Transform[] random;
    int index;
 
    
    

    // Use this for initialization
    void Start()
    {
        StartCoroutine("NextRandom");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator NextRandom()
    {
        while (Time.timeScale != 0)
        {
            index = Random.Range(0, 6);
            yield return new WaitForSeconds(5);

        }
    }*/
}