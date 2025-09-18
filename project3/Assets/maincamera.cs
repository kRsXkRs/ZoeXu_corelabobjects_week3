using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera targetCamera; 

    public void SwitchCamera()
    {
       
        if (Camera.main != null)
            Camera.main.gameObject.SetActive(false);

    
        if (targetCamera != null)
            targetCamera.gameObject.SetActive(true);
    }
}
