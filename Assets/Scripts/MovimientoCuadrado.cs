using UnityEngine;

public class MovimientoCuadrado : MonoBehaviour
{
    public float velocidad = 5f;


    private Vector3 direccion = Vector3.right;

    void Update()
    {
       
        float movimientoX = Input.GetAxisRaw("Horizontal");
        float movimientoY = Input.GetAxisRaw("Vertical");

       
        if (movimientoX != 0 || movimientoY != 0)
        {
            direccion = new Vector3(movimientoX, movimientoY, 0f).normalized;
        }


        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}