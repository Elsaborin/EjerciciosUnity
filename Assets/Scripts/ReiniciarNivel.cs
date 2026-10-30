using UnityEngine;
using UnityEngine.SceneManagement; // Librería obligatoria para cambiar o reiniciar escenas

public class ReiniciarNivel : MonoBehaviour
{
    void Update()
    {
        // Detecta si se presiona la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Restaura el tiempo a la normalidad (crucial porque tu script de victoria lo pausa a 0)
            Time.timeScale = 1f;

            // Carga exactamente la escena en la que estás jugando ahorita
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}