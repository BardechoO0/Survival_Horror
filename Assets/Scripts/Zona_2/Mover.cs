using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public bool x;

    public bool y;
    void Start()
    {
        
    }
    public void Cheek() {

        StartCoroutine(Subir());
    }

    public void Cheek2()
    {
        StartCoroutine(Bajar());
    }
    IEnumerator Subir() {
       x= true;
        yield return new WaitForSeconds(9f);
        x = false;
    }

    IEnumerator Bajar()
    {
        y = true;
        yield return new WaitForSeconds(4.5f);
        y = false;
    }
    void Update()
    {
        if (x)
        {
            transform.Translate(new Vector3(0, 0, -0.5f) * Time.deltaTime);
        }

        if (y)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        }
    }
}
