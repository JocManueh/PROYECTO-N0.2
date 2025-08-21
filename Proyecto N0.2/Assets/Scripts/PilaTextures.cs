using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PilaTextures : MonoBehaviour {

    // Pila global para toda la clase
    Stack<string> pilanombres = new Stack<string>();
    [SerializeField] private TMP_InputField inputNombre;  

    void Start()
    {
        Debug.Log("Pila inicializada, pero vac�a");
    }

    // M�todo para bot�n 1
    public void PushString()
    {
        
        Debug.Log("El elemento del tope es:"+pilanombres.Peek());
    }

    // M�todo para bot�n 2
    public void PeekString()
    {
        if (pilanombres.Count > 0)
        {
            Debug.Log("Elemento en el tope de la pila: " + pilanombres.Peek());
        }
        else
        {
            Debug.Log("La pila est� vac�a (Peek).");
        }
    }

    // M�todo para bot�n 3
    public void PopString()
    {
        if (pilanombres.Count > 0)
        {
            string eliminado = pilanombres.Pop();
            Debug.Log("Se elimin� de la pila: " + eliminado);
        }
        else
        {
            Debug.Log("La pila est� vac�a (Pop).");
        }
    }
}






