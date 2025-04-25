using UnityEngine;

[CreateAssetMenu(fileName = "NewRelic", menuName = "Relics/New Relic")]
public class Relic : ScriptableObject
{
    public string relicName;
    public string description;
    public Sprite icon;

    public GameObject effectPrefab; // Pour effets visuels optionnels
}
