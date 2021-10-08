using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chas : MonoBehaviour
{

    public AudioSource MonsterScream;

    public bool alerted;

    Transform target;
    NavMeshAgent agent;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    void Update()
    {
        if (alerted == true)
        {
            agent.SetDestination(target.position);
        }
    }
    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            agent.speed = 0.0f;
            agent.SetDestination(target.position);
            MonsterScream.Play();
            StartCoroutine(Timer());
            Destroy(GetComponent<BoxCollider>());
            alerted = true;
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4);
        agent.speed = 20.0f;
    }

}
