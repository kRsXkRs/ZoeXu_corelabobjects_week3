using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    public GameObject loseUI;
    public Camera loseCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            if (Camera.main != null)
                Camera.main.gameObject.SetActive(false);
            loseCamera.gameObject.SetActive(true);

            if (loseUI != null)
                loseUI.SetActive(true);


        }
    }
}
