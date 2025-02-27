using UnityEngine;
using UnityEngine.AI;

public class Enemigo_2 : MonoBehaviour
{
    public Transform objetivo;
    //public Animator animator;
    public NavMeshAgent agent;
    public float distanceEnemy = 10f;
    private bool detected;
    public bool Zona = false;

    void Start()
    {
        //animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {

        float distance = Vector3.Distance(transform.position, objetivo.position);

        // Detección por distancia
        if (distance <= distanceEnemy && Zona)
        {
            detected = true;
        }
        else
        {
            detected = false;
        }

        // Comprobación de visión con raycast
        VisualDetect();

        if (detected)
        {
            agent.SetDestination(objetivo.position);
        }
        else
        {
            agent.ResetPath(); // Detiene el movimiento si el jugador no está en rango
        }

        // Actualizar la animación
        //animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    void VisualDetect()
    {
        Vector3 directionToPlayer = (objetivo.position - transform.position).normalized;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, directionToPlayer, out hit, distanceEnemy))
        {
            if (hit.collider.CompareTag("Player")) // Asegurar que el objeto detectado es el jugador
            {
                detected = true;
            }
        }
        Debug.DrawRay(transform.position, directionToPlayer * distanceEnemy, Color.red);
    }
}
