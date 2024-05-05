using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    GameObject player;
    PlayerHealthNShit playerHealth;
    [SerializeField] bool hasLOS;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealthNShit>();
    }

    // Update once per fixed frame
    void FixedUpdate()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position);
        if(ray.collider != null)
        {
            hasLOS = ray.collider.CompareTag("Player");
            if(hasLOS)
            {
                playerHealth.RayHittin(hasLOS);
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
            }
            else
            {
                playerHealth.RayHittin(hasLOS);
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
            }
        }
    }
}
