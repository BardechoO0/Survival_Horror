using UnityEngine;

public class Gemas : MonoBehaviour
{
    [SerializeField] GameObject IMG;

    [SerializeField] Abrir_bunker Ab;

    public int N_B;

    public bool ativate = false;
    public bool y;


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {
            IMG.SetActive(true);
            y = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        IMG.SetActive(false);

        y = false;
    }

    private void Start()
    {
        IMG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && y && ativate == false)
        {

            if (N_B == 1) { Ab.G1(); gameObject.SetActive(false); } else if (N_B == 2) { Ab.G2(); gameObject.SetActive(false); } else if (N_B == 3) { Ab.G3(); gameObject.SetActive(false); } else if (N_B == 4) { Ab.G4(); gameObject.SetActive(false); }
            
            ativate = true;

        }


    }
}
