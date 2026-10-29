using UnityEngine;
using UnityEngine.SceneManagement;   

public class MuerteJugador : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("pom");

            // Vuelve a cargar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}