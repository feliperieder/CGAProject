using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float mouseSensitivity = 1000f;
    public float jumpForce = 1.5f;
    public float gravity = -9.81f;

    public Light flashlight;

    public Transform cameraTransform;

    float xRotation = 0f;
    float yVelocity = 0f;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // Captura o mouse
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

        //Movimento
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        if (controller.isGrounded && yVelocity < 0)
        {
            yVelocity = -2f; // mantém colado no chão
        }

        //Pulo
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            yVelocity = Mathf.Sqrt(jumpForce * -2f * gravity);
        }

        //Gravdade
        yVelocity += gravity * Time.deltaTime;

        Vector3 velocity = new Vector3(0, yVelocity, 0);
        controller.Move((move * speed + velocity) * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }

        if (Input.GetKeyDown(KeyCode.E))
        { 
            flashlight.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            flashlight.color = Color.red;
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            flashlight.color = Color.green;
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            flashlight.color = Color.blue;
        }
    }
}