using UnityEngine;

public class DestroyerController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Signs")) return;
        Destroy(collision.gameObject);
    }
}
