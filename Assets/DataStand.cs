using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStand : MonoBehaviour {
    public GameObject spawnPrefab;
    GameObject num;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void SpawnMe()
    {
        num = (GameObject)Instantiate(spawnPrefab, transform.position, transform.rotation);
        num.transform.position = new Vector3(transform.position.x -1 , transform.position.y + 1, transform.position.z);
    }


    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            SpawnMe();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(num);
        }
    }
}
