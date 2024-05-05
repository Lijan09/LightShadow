using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthNShit : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] bool isPlayerLight = false; 

    public void RayHittin(bool hasLOS)
    {
        if (hasLOS && isPlayerLight)
        {
            health -= 1;
        }
        else if (!hasLOS && !isPlayerLight)
        {
            health -= 1;
        }
    }

    private void Start()
    {
        health = 100;
    }

    private void Update()
    {
        // If x is pressed, change the player's light status
        if (Input.GetKeyDown(KeyCode.X))
        {
            isPlayerLight = !isPlayerLight;
        }

        if (health <= 0)
        {
            Debug.Log("OH! no! I'm dead!");
            health = 100;
        }
    }
}
