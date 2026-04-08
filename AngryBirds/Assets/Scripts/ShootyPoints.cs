using TMPro;
using UnityEngine;

public class ShootyPoints : MonoBehaviour
{
    public TMP_Text textoPuntos;
    int puntaje = 0;


    // Update is called once per frame
    public void Contador()
    {
        puntaje++;
        textoPuntos.text = puntaje.ToString();
    }
}
