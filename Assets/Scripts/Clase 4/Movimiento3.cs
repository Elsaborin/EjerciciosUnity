using Unity.VisualScripting;
using UnityEngine;
public class Movimiento3 : MonoBehaviour
{
    public float velocidad = 5f;
    private CambioColor1 cambioColor;
    void Start()
    {
        cambioColor = GetComponent<CambioColor1>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            
        cambioColor.CambiarColor(Color.green);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.yellow);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.red);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.blue);
        }
    }
}
