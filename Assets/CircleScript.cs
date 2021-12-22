using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CircleScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private Vector3 mousePosition;
    Vector2 movement;
    private int score = 0;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = "Skor : " + score.ToString();
        Destroy(collision.gameObject);

    }
}
