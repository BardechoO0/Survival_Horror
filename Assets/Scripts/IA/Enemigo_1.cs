using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo_1 : MonoBehaviour
{
    public Transform objetivo;
    //public Animator anim;
    public NavMeshAgent agent;

    [SerializeField] Transform[] pz = new Transform[2];

    public float distanceEnemy = 10f;

    public Vector3 distance;

    public bool detected;

    public bool x = true;

    public bool track = false;

    public int R;

    public new Vector3 y;
    
    void Start()
    {
        R = Random.Range(0,pz.Length);

        agent.destination = pz[R].position;

        y = new Vector3(pz[R].position.x, transform.position.y, pz[R].position.z);

        x = true;
    }

    IEnumerator tiempo(int t)
    {

        yield return new WaitForSeconds(t);

        agent.destination = pz[R].position;

        y = new Vector3(pz[R].position.x, transform.position.y, pz[R].position.z);

        x = true;

    }

    IEnumerator cambio(int t) { 
        
        yield return new WaitForSeconds(10);
        R = Random.Range(0, pz.Length);

        agent.destination = pz[R].position;

        y = new Vector3(pz[R].position.x, transform.position.y, pz[R].position.z);
        detected = false;
        x = true;
        StopCoroutine(cambio(1));
    }

    

    IEnumerator t()
    {
        yield return new WaitForSeconds(3);
        track = false ;
        StartCoroutine(cambio(1));
        agent.speed = 1.5f;
    }
    void Update()
    {
        

        // Detección por distancia
        /*if (distance <= distanceEnemy)
        {
            detected = true;
            StopAllCoroutines();
        }
        else
        {
            detected = false;
            agent.destination = pz[R].position;
        }*/

        // Comprobación de visión con raycast
        VisualDetect();

        if (detected)
        {
            agent.SetDestination(objetivo.position);
        }
        else
        {
            
        }
        if (transform.position == y && x == true && detected == false) {

            R = Random.Range(0, pz.Length);
            StopCoroutine(cambio(0));
            StartCoroutine(tiempo(3));
            x = false;
            

            

        }

        if (x== false && transform.position != y && detected == false)
        {

            StartCoroutine(cambio(0));
            StopCoroutine(tiempo(3));
            x = false;

        }
        
    }
    void VisualDetect()
    {
        Vector3 directionToPlayer = transform.position;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(distance), out hit, distanceEnemy))
        {
            if (hit.collider.CompareTag("Wall") && track == false)
            {

                detected = false;
                
            }else if (hit.collider.CompareTag("Player"))
            {
                track = true;
                StopAllCoroutines();
                    detected = true;
                StartCoroutine(t());
                agent.speed = 2f;
                

            }else if (hit.collider.CompareTag(null)&&track == false)
            {
                detected = false;
            }


        }
        Debug.DrawRay(transform.position, transform.TransformDirection(distance), Color.red);
    }
}
