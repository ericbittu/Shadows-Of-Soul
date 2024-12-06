using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            // Obtém a direção da câmera
            Vector3 forward = Camera.main.transform.forward;
            Vector3 right = Camera.main.transform.right;

            // Normaliza as direções
            forward.y = 0f;
            right.y = 0f;
            forward.Normalize();
            right.Normalize();

            // Calcula a direção do movimento
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            moveDirection = (forward * vertical + right * horizontal).normalized * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
