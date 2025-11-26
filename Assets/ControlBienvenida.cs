using UnityEngine;

public class ControlBienvenida : MonoBehaviour
{
    public GameObject canvasBienvenida;
    public GameObject arCamera; // DEBE ESTAR DESACTIVADO EN EL EDITOR

    void Start()
    {
        // Solo mostramos el cartel. Asumimos que la cámara AR está desactivada.
        canvasBienvenida.SetActive(true);
    }

    public void DesactivarCartel()
    {
        // 1. Activa la cámara AR para iniciar la funcionalidad principal
        if (arCamera != null)
        {
            arCamera.SetActive(true);
        }
        
        // 2. Desactiva el cartel de bienvenida
        canvasBienvenida.SetActive(false);
    }
}