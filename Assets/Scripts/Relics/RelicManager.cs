using System.Collections.Generic;
using UnityEngine;

public class RelicManager : MonoBehaviour
{
    public static RelicManager Instance;

    public List<Relic> activeRelics = new List<Relic>();

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        else Instance = this;
    }

    public void AddRelic(Relic relic)
    {
        if (!activeRelics.Contains(relic))
        {
            activeRelics.Add(relic);
            Debug.Log("Relic added: " + relic.relicName);
        }
    }

    public bool HasRelic(string name)
    {
        return activeRelics.Exists(r => r.relicName == name);
    }
}
