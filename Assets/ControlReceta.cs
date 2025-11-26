using UnityEngine;

public class ControlReceta : MonoBehaviour
{
    public Animator recetaAnimator;
    public float[] PuntosDeParada = { 0.1f,2.5f, 6.0f, 10.5f, 13.0f};

    private int pasoActual = 0;
    [SerializeField] private string nombreClip = "ClipRecetaCompleta";

    void Start()
    {
        if (recetaAnimator == null)
        {
            Debug.LogError("El Animator no está asignado en 'Trago1'. Asigna el componente Animator.");
            return;
        }

        if (string.IsNullOrEmpty(nombreClip))
        {
            Debug.LogError("El nombre del clip de animación no está configurado.");
            return;
        }

        recetaAnimator.Play(nombreClip, -1, PuntosDeParada[0]);
    }

    public void AvanzarPaso()
    {
        if (pasoActual < PuntosDeParada.Length - 1)
        {
            pasoActual++;
            MoverAnimacionAPaso();
        }
    }

    public void RetrocederPaso()
    {
        if (pasoActual > 0)
        {
            pasoActual--;
            MoverAnimacionAPaso();
        }
    }

    private void MoverAnimacionAPaso()
    {
        float tiempoDeseado = PuntosDeParada[pasoActual];

        recetaAnimator.Play(nombreClip, -1, tiempoDeseado);

        Debug.Log($"Paso actual: {pasoActual + 1}. Tiempo de animación: {tiempoDeseado}s");
    }
}