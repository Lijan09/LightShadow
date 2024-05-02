
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    GameObject bulb;
    private Rigidbody2D body;
    bool hasLOS;

    // Start is called before the first frame update
    void Start()
    {
        bulb = GameObject.FindGameObjectWithTag("Bulb");
    }
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, bulb.transform.position - transform.position);
        if(ray.collider != null)
        {
            hasLOS = ray.collider.CompareTag("Bulb");
            if(hasLOS)
            {
                Debug.DrawRay(transform.position, bulb.transform.position - transform.position, Color.green);
            }
            else
            {
                Debug.DrawRay(transform.position, bulb.transform.position - transform.position, Color.red);
            }
        }
    }

}
