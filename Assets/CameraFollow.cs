using UnityEngine;


 
public class CameraFollow : MonoBehaviour
{
    // The player we want the camera to follow
    public Transform target;

  
    public float smooth = 5f;

    // The offset distance between the camera and player
    public Vector3 offset = new Vector3(0, 8, -6);

    void LateUpdate()
    {
        Vector3 desiredPos = target.position + offset;

        // Update camera position AFTER player moves
        transform.position = Vector3.Lerp(transform.position, desiredPos, smooth * Time.deltaTime);
        transform.LookAt(target);
    }
}


