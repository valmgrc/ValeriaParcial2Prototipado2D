using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemigosController : MonoBehaviour
{
    
    public TMP_Text textoPuntos;
    static int puntaje = 0;
    public Rigidbody2D cerdito;

    private Controles inputActions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        inputActions = new Controles();
    }

    private void OnEnable()
    {
        inputActions.PajarosVScerdos.Enable();
        inputActions.PajarosVScerdos.Presionado.started += LePico; //suscripcion
    }

    void LePico(InputAction.CallbackContext handler)
    {
            
        Debug.Log("Le pico al click izquierdo)");
        
    }


    void NoLePico(InputAction.CallbackContext handler)
    {
        Debug.Log("Espacio");
    }




    private void OnDisable()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TablonesMadera")
        {
        Destroy(gameObject);
        //puntaje = puntaje + 1;
        puntaje++;
        textoPuntos.text = puntaje.ToString();
        }
    }

   

  
}
