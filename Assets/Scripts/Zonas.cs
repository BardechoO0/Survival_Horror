using UnityEngine;
using UnityEngine.SceneManagement;

public class Zonas : MonoBehaviour
{
    public int x;

    
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player" && x ==1)
            {
                SceneManager.LoadScene(2);
            }

        if (other.gameObject.tag == "Player" && x == 2)
        {
            SceneManager.LoadScene(3);
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
