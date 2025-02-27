using UnityEngine;

public class Botones : MonoBehaviour
{
    public bool boton_1;
    public bool boton_2;
    public bool boton_3;
    public bool boton_4;

    
    void Start()
    {
        boton_1 =false;
        boton_2 =false;
        boton_3 =false;
        boton_4 =false;
    }

    public void B1() { boton_1 = true; }
    public void B2() { boton_2 = true; }
    public void B3() { boton_3 = true; }
    public void B4() { boton_4 = true; }

    void Update()
    {
        if (boton_1 == true &&  boton_2 == true && boton_3 == true && boton_4 == true)
        {

           gameObject.SetActive(false);

        }
    }
}
