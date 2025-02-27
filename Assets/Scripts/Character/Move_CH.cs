using UnityEngine;

public class Move_CH : MonoBehaviour
{
    public float speed = 5f;
    public Camera cam;
    public Transform cam_2;

    [SerializeField] Animator anim;

    private float Sh = 1;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift)) {

            Sh = 1.5f;

            anim.SetFloat("Run", 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {

            Sh = 1f;

            anim.SetFloat("Run", 0);
        }

        Vector3 movement = new Vector3(moveX, 0f, moveZ*Sh) * speed * Time.deltaTime;
        movement = cam.transform.TransformDirection(movement);
        movement.y = 0f;
        transform.Translate(movement, Space.World);

        anim.SetFloat("Horizontal",moveX);
        anim.SetFloat("Vertical", moveZ);

        transform.rotation = Quaternion.Euler(transform.rotation.x, cam_2.rotation.y, transform.rotation.z);

        print(transform.rotation);
    }
}
