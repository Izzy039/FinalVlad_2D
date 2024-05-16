using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] GameObject vcam;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vcam.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vcam.SetActive(false);
        }
    }
}
