using TMPro;
using UnityEngine;

public class EnemigosController : MonoBehaviour
{
    //public GameObject madera1;
    public TMP_Text textoPuntos;
    static int puntaje = 0;
    public Rigidbody2D cerdito;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        //puntaje = puntaje + 1;
        puntaje++;
        textoPuntos.text = puntaje.ToString();
    }

   

  
}
