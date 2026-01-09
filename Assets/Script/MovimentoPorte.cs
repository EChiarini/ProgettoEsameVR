using UnityEngine;

public class MovimentoPorte : MonoBehaviour
{
    public float aperturaVoluta = 0f;
    public float velocita = 2.0f;

    private Quaternion aperturaVolutaTradotta;
    private Quaternion aperturaIniziale;

    private bool portaAperta = true;

    void Start()
    {
        aperturaIniziale = transform.localRotation;
        aperturaVolutaTradotta = Quaternion.Euler(0, aperturaVoluta, 0) * aperturaIniziale;
    }

    void Update()
    {
        Quaternion cheFaccio = portaAperta ? aperturaIniziale : aperturaVolutaTradotta;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, cheFaccio, Time.deltaTime * velocita);
    }

    public void ToggleDoor()
    {
        portaAperta = !portaAperta;
    }
}