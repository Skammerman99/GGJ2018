using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroWave_Click : MonoBehaviour {

    public GameManager gm;
    public int level = 1;

    public static bool range = false;

    float timer = 0;

	public  string correctCode;
	public static string playerCode = "";

	public static int totalDigits = 0;

	public static string didclick = "n";
	// Use this for initialization
	void Start () {
        correctCode = transform.parent.GetComponent<Code>().code;
        playerCode = "";
        gm = transform.parent.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (playerCode);

		if (totalDigits == 4) 
		{
			if (playerCode == correctCode) {

                gm.SceneLoader(level+1);
				//Debug.Log ("Correct");
			} 

			else 
			{
				playerCode = ("");
				totalDigits = 0;
					
				//Debug.Log ("You are the weakest link!");
			}
		}
	}

    void OnMouseUp()
    {
        if (range)
        {
            playerCode += gameObject.name;
            totalDigits += 1;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
            StartCoroutine(waittochange());
            didclick = "y";


        }
    }
	void OnMouseOver()
	{
        if (range)
        {
            if (didclick == "n")
                GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
            //Debug.Log ("Hovering");
        }
	}

	void OnMouseExit()
	{
        if (range)
        {
            if (didclick == "n")
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            //Debug.Log ("Not Hovering");
        }
	}

	IEnumerator waittochange()
	{
        if (range)
        {
            yield return new WaitForSeconds(1);
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            didclick = "n";
        }
	}
}
