using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float maxVertical = 4.5f;
    public float maxHorizontal = 8.5f;
    public GameObject squarePrefab;
    public void Start()
    {
        int randomSquare = Random.Range(10, 15);

        for (int i=0; i < randomSquare; i++)
        {
            Instantiate(squarePrefab, new Vector3(Random.Range(-maxHorizontal, maxHorizontal), Random.Range(-maxVertical, maxVertical), 0), Quaternion.identity);
        }
    }
}
