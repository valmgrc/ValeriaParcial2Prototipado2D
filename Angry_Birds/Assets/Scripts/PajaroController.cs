using UnityEngine;

public class PajaroController : MonoBehaviour
{

    public float fuerzaPajaro = 5f;
    public LineRenderer linea;
    public Rigidbody2D rb;


    Vector2 lineaComienzo;
    Vector2 lineaFinal;
    Vector3 posicionInicial;

    public GameObject suelo;
 
    //aqui la variable se le asigna true porque aún tiene tiros restantes, comienza con 3
    bool lanzar = true;

    //tiros del pajarito
    int tiros = 3;
    

    void Start()
    {
        linea = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody2D>();
        

        posicionInicial = transform.position;
    }

    public void Update()
    {
        if (tiros > 0)
        {
            if (lanzar == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    lineaComienzo = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }

                if (Input.GetMouseButtonUp(0))
                {
                    Vector2 lineaFinal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 velocidad = (lineaFinal - lineaComienzo) * fuerzaPajaro;


                    rb.linearVelocity = velocidad;
                    lanzar = false;
                }
            }
        }

        if (lanzar == false) 
        {
            if (rb.linearVelocity.magnitude < 0.1f)
            {
                tiros = tiros - 1;

                if (tiros > 0)
                {
                    rb.linearVelocity = Vector2.zero;
                    rb.angularVelocity = 0f;

                    transform.position = posicionInicial;

                    lanzar = true;
                    linea.enabled = true;
                }
                else
                {
                    gameObject.SetActive(false);
                }
            }
        }
    }
    
}
