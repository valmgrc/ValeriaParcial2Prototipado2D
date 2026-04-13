using TMPro;
using UnityEngine;

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
