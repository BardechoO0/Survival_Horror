using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Collider_botones : MonoBehaviour
{
    [SerializeField] GameObject IMG;

    

    [SerializeField] Botones Bt;

    [SerializeField] Animator amin;

    [SerializeField] GameObject pueta;

    public int N_B;

    public bool ativate = false;
    public bool y;
    

    private void OnTriggerEnter(Collider other)
    {
 

        if (other.gameObject.tag =="Player")
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

            if (N_B == 1) { Bt.B1(); } else if (N_B == 2) { Bt.B2(); } else if (N_B == 3) { Bt.B3(); } else if (N_B == 4) { Bt.B4(); }
            amin.SetBool("Act",true);   
            ativate = true;

        }

        
    }
}
