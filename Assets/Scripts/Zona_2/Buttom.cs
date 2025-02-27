using UnityEngine;

public class Buttom : MonoBehaviour
{
    [SerializeField] GameObject IMG;

    [SerializeField] Mover Mv;

    [SerializeField] Animator amin;

    [SerializeField] GameObject pueta;

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

            Mv.Cheek();
            amin.SetBool("Act", true);
            ativate = true;

        }

        
    }
}
