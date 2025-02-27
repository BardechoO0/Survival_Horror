using UnityEngine;

public class Zona_2 : MonoBehaviour
{
    [SerializeField] Enemigo_2 EN_2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            EN_2.Zona = true;
        }
          
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EN_2.Zona = false;
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
