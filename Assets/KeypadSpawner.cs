using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadSpawner : MonoBehaviour {

    public GameObject spawnPrefab;
    bool spawned = false;
    public bool ready = false;

    // Use this for initialization
    void Start () {

		
	}

    void SpawnMe()
    {
        GameObject keypad = (GameObject)Instantiate(spawnPrefab, transform.position, transform.rotation);

    }


    // Update is called once per frame

    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (CompareTag("Player"))
        {

            ready = true;
        }
    }

    private void OnTriggerExit2D(Collision2D collision)
    {
        if (CompareTag("Player"))
        {

            ready = false;
        }

    }

    void Update () {
        if (Input.GetKey(KeyCode.E) && ready)
        {
            if (!spawned)
            {
                SpawnMe();
                spawned = true;
            }
        }

    }
}
