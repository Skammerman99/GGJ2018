using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadSpawner : MonoBehaviour {

    public GameObject spawnPrefab;
    bool spawned = false;

    // Use this for initialization
    void Start() {

		
	}

    void SpawnMe()
    {
        GameObject keypad = (GameObject)Instantiate(spawnPrefab, transform.position, transform.rotation);
        keypad.transform.position = new Vector3(keypad.transform.position.x, keypad.transform.position.y + 3, keypad.transform.position.z);
    }


    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            if (Input.GetKey(KeyCode.E))
            {
                SpawnMe();
            }
        }
    }


    void Update() {
        

    }
}
