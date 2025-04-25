using UnityEngine;
using DG.Tweening;

using UnityEngine;
using DG.Tweening; // Pour DotTween
using MoreMountains.Feedbacks; // Pour FEEL

public class RelicPickup : MonoBehaviour
{
    public Relic relic;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision détectée avec : " + other.name);
        Debug.Log("Tag détecté : " + other.tag);
        Debug.Log("Collider layer: " + other.gameObject.layer + " | Tag: " + other.tag);
        Debug.Log("Objet ignoré car pas Player : " + other.name);


        GameObject root = other.transform.root.gameObject;

        if (!root.CompareTag("Player"))
        {
            Debug.Log($"[⛔] Objet ignoré car le root n’est pas le Player: {root.name}");
            return;
        }


        if (!other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Objet ignoré car pas Player : " + other.name);
            return;
        }

        Debug.Log("Relic touched by player.");

        RelicManager.Instance.AddRelic(relic);

        if (relic is IRelicEffect effect)
        {
            effect.ApplyEffect(other.gameObject);
        }

        MMFeedbacks feedbacks = GetComponent<MMFeedbacks>();
        if (feedbacks != null)
        {
            Debug.Log("Trying to play feedbacks");
            feedbacks.Initialization();
            feedbacks.PlayFeedbacks();
        }

        transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        Destroy(gameObject, 0.25f);
    }

}
