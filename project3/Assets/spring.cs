using UnityEngine;

public class SpringPad : MonoBehaviour
{
    public float launchForce = 10f;

    void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody != null && col.gameObject.CompareTag("Player"))
        {
            col.rigidbody.AddForce(Vector3.up * launchForce, ForceMode.VelocityChange);
        }
    }
}
