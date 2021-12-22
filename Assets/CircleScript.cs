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

    public SpawnerScript spawnerScript;
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
        collision.gameObject.SetActive(false);
        StartCoroutine(SpawnAgain(collision.gameObject));
    }

    IEnumerator SpawnAgain(GameObject obj, int time = 3)
    {
        yield return new WaitForSeconds(time);
        obj.SetActive(true);
        float randomHorizontal = Random.Range(-spawnerScript.maxHorizontal, spawnerScript.maxHorizontal);
        float randomVertical = Random.Range(-spawnerScript.maxVertical, spawnerScript.maxVertical);
        if(!GetComponent<Collider2D>().bounds.Contains(new Vector3(randomHorizontal, randomVertical, 0)))
        {
            obj.transform.position = new Vector3(randomHorizontal, randomVertical, 0);
        } else
        {
            StartCoroutine(SpawnAgain(obj, 0));
        }
    }
}
