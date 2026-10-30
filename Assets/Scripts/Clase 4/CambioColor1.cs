using UnityEngine;
public class CambioColor1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            spriteRenderer.color = Color.red;
        }
    }
    public void CambiarColor(Color nuevoColor)
    {
        spriteRenderer.color = nuevoColor;
    }
}
