using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float xInitialForce;
    public float yInitialForce;
    // Start is called before the first frame update
    void Start()
    {
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);
        float randomDirection = Random.Range(0,2);

        if (randomDirection < 1.0f)
        {
            rb.AddForce(new Vector2(-xInitialForce, yRandomInitialForce) * speed * 5);
        } else
        {
            rb.AddForce(new Vector2(xInitialForce, yRandomInitialForce) * speed * 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
