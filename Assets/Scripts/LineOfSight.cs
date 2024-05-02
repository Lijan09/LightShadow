using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    private GameObject player;
    private bool hasLOS = false;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position);
        if(ray.collider != null)
        {
            hasLOS = ray.collider.CompareTag("Player");
            if(hasLOS)
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
            }
            else
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
            }
        }
    }
}