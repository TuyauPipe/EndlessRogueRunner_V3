using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player est tomb� dans la KillZone !");
            // TODO : D�clencher la mort du joueur ici
            // Par exemple appeler GameOverManager.ShowGameOver()
        }
    }
}
