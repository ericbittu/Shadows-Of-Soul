using UnityEngine;

public class LockCursor : MonoBehaviour
{
    void Start()
    {
        // Trava o cursor no centro da tela e o torna invis�vel
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Permite que o cursor seja liberado e vis�vel se a tecla ESC for pressionada
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        // Trava o cursor novamente se o bot�o esquerdo do mouse for pressionado
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
