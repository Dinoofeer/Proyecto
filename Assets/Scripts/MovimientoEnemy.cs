using UnityEngine;

public class VelocidadPelota : MonoBehaviour
{
    public float velocidadHorizontal = 4f;
    public float velocidadVertical = 4f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = new Vector2(
            velocidadHorizontal,
            velocidadVertical
        );
    }
}