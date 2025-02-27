using System.Collections;
using UnityEngine;

public class Abrir_bunker : MonoBehaviour
{
    public bool gem_1;
    public bool gem_2;
    public bool gem_3;
    public bool gem_4;

    public bool zona;

    public bool activo = false;

    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;

    public bool mover = false;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            zona = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "Player")
        {
            zona = false;
        }
    }

    public void G1()
    {
        gem_1 = true;
    }
    public void G2()
    {
        gem_2 = true;
    }
    public void G3()
    {
        gem_3 = true;
    }
    public void G4() { 
        gem_4 = true;
    }

    IEnumerator conteo(int i) {

        yield return new WaitForSeconds(1.5f);

        mover = false;    
      }
    void Update()
    {
        if (gem_1 && gem_2 && gem_3 && gem_4 && activo == false && zona && Input.GetKeyDown(KeyCode.E))
        {
            mover = true;
            activo = true;
            StartCoroutine(conteo(0));
        }
        if (mover) {
        
         p1.transform.Translate(Vector3.up * Time.deltaTime);
         p2.transform.Translate(-Vector3.up * Time.deltaTime);
        
        }
    }
}
