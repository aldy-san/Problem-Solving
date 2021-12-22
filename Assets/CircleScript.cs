using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private Vector3 mousePosition;
    Vector2 movement;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("hai");
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, speed);
        }
    }

}
