using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    public Camera myCamera;
    bool used = false;

    void OnTriggerEnter(Collider other)
    {
        if (used) return;
        if (!other.CompareTag("Player")) return;

        if (Camera.main != null) Camera.main.enabled = false;
        if (myCamera != null) myCamera.enabled = true;

        used = true;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
