using UnityEngine;

public class LockCursor : MonoBehaviour
{
    void Start()
    {
        // Trava o cursor no centro da tela e o torna invisível
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Permite que o cursor seja liberado e visível se a tecla ESC for pressionada
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        // Trava o cursor novamente se o botão esquerdo do mouse for pressionado
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
