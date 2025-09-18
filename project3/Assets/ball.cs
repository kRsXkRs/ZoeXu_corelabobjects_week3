using UnityEngine;

public class BallDrop : MonoBehaviour
{
    private Rigidbody rb;
    private bool hasDropped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hasDropped)
        {
            rb.isKinematic = false;  

            
            float randomX = Random.Range(-5f, 5f);
            rb.AddForce(new Vector3(randomX, 0, 0), ForceMode.Impulse);

            hasDropped = true;
        }
    }
}
