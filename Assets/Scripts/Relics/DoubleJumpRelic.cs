using UnityEngine;
using MoreMountains.CorgiEngine;

[CreateAssetMenu(fileName = "DoubleJumpRelic", menuName = "Relics/Double Jump")]
public class DoubleJumpRelic : Relic, IRelicEffect
{
    public void ApplyEffect(GameObject player)
    {
        CharacterJump jumpAbility = player.GetComponent<CharacterJump>();

        if (jumpAbility != null)
        {
            jumpAbility.NumberOfJumps = 2; // Active double saut
            Debug.Log("Double Jump activated!");
        }
        else
        {
            Debug.LogWarning("CharacterJump not found on player.");
        }
    }
}
