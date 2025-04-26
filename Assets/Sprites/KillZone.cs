using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player est tombé dans la KillZone !");
            // TODO : Déclencher la mort du joueur ici
            // Par exemple appeler GameOverManager.ShowGameOver()
        }
    }
}
