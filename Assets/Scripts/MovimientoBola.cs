using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 7f;
    private Rigidbody2D rb;

    void Start()
    {
        // Obtiene la referencia al componente de físicas
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal (flechas izquierda/derecha o teclas A/D)
        float movimientoX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);

        // Salto: evalúa si se presiona Espacio y si la bola casi no tiene movimiento vertical (para evitar saltos en el aire)
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.linearVelocity.y) < 0.05f)
        {
            rb.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);
        }
    }
}
