using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float sensitivity = 2.0f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
