using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;
    public float spawnX = 45f;       // Regular spawn x-position

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(25f);
        spawnPipe(42f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            spawnPipe(spawnX);
            timer = 0;
        }
    }
    void spawnPipe(float xPosition)
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        float spawnY = Random.Range(lowestPoint, highestPoint);
        Instantiate(pipe, new Vector3(xPosition, spawnY, 0), Quaternion.identity);
    }
}
