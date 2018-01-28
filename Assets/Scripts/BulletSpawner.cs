using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    float timer = 0f;
    public float delay = 2f;
    public float speed = 3, direction = -1;

    // Use this for initialization
    void Start()
    {
        timer = 0;
    }

    void SpawnMe()
    {
        GameObject boolet = (GameObject)Instantiate(spawnPrefab, transform.position, transform.rotation);
        boolet.GetComponent<Rigidbody2D>().velocity = new Vector3(direction * speed, 0,0);

    }

    // Update is called once per frame
    void Update()
    {
        
            timer += Time.deltaTime;
            if (timer > delay)
            {
                SpawnMe();
                timer = 0;
            }

        
    }


}
