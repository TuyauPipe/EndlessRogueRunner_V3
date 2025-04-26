using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(5f, 2f, -10f);
    public float followSpeed = 2f;

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + offset;
            targetPosition.y = Mathf.Clamp(targetPosition.y, 0f, Mathf.Infinity); // Verrouille la caméra pour ne pas descendre sous Y=0 si besoin
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
