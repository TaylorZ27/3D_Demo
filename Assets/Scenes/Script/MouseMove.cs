using UnityEngine;

public class MouseMove : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    float yRotation = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;   
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //control rotation around x axis
        xRotation -= mouseY;

        //we clamp the rotation so we cant Over-rotate (life in real life)
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //control rotation around y axis
        yRotation += mouseX;

        //applying both rotations

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);


    }
}
