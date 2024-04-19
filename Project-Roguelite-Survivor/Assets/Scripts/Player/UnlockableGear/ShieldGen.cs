using System.Collections;
using UnityEngine;

public class ShieldGen : MonoBehaviour
{
    public int ShieldLevel = 20;
    public int RegenSpeed = 3;
    public int ShieldCapacity = 20;

    // Start is called before the first frame update
    void Start()
    {
        var healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthAndCollision>();
        healthScript.SetShield(this);

        StartCoroutine(ShieldRegenCoroutine());

    }

    IEnumerator ShieldRegenCoroutine()
    {
        while (true)
        {
            // Will lock the shield level between 0 and the capacity
            ShieldLevel = Mathf.Clamp(ShieldLevel + 1, 0, ShieldCapacity);
            yield return new WaitForSeconds(RegenSpeed);
        }
    }

    // Applies damage to the shield and returns any over
    public int Damage(int value)
    {
        // Deduct the shield points
        ShieldLevel -= value;

        var overflow = 0;

        // Disable this condition if you don't want extra shield damage
        // to be applied to the player's health
        if (ShieldLevel < 0)
        {
            overflow = Mathf.Abs(ShieldLevel); // turns any negative value to positive
            ShieldLevel = 0;
        }

        return overflow; // returns the overflowed value to be applied elsewhere
    }
}