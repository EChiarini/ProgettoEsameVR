using UnityEngine;

public class MovimentoPorte : MonoBehaviour
{
    [Header("Impostazioni Porta")]
    public float openAngle = 90f;
    public float speed = 2.0f;

    private Quaternion closedRotation;
    private Quaternion openRotation;
    private bool isOpen = false;

    void Start()
    {
        closedRotation = transform.localRotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * closedRotation;
    }

    void Update()
    {
        Quaternion target = isOpen ? openRotation : closedRotation;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * speed);
    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
    }

    public void OpenPanic()
    {
        isOpen = true;
    }
}