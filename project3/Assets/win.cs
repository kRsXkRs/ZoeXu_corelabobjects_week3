using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject winUI;      
    public Camera winCamera;        
    public bool stopBallOnWin = true; 

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

      
        if (Camera.main != null)
            Camera.main.gameObject.SetActive(false);
        if (winCamera != null)
            winCamera.gameObject.SetActive(true);


        if (winUI != null)
            winUI.SetActive(true);

        
        if (stopBallOnWin)
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;     
                rb.angularVelocity = Vector3.zero;   
                rb.constraints = RigidbodyConstraints.FreezeAll;

          

            }
        }
    }
}
