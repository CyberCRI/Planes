using UnityEngine;
using System.Collections;

public class power : MonoBehaviour {

    GameObject goCollectible;

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        if (GameObject.FindGameObjectWithTag("gauge").GetComponent<gauge>().gaugeLevel > 1)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    pouvoir1();
                }
                else
                {
                    pouvoir2();
                }
            }
        }
    }

    void pouvoir1()
    {
        GameObject.FindGameObjectWithTag("gauge").GetComponent<gauge>().gaugeLevel -= 0.1f;
        if (GetComponent<move>().speed < 15)
        {
            GetComponent<move>().speed += 0.02f;
        }
        Camera.main.GetComponent<camcam>().camX -= 0.2f/(8-Camera.main.GetComponent<camcam>().camX);
    }

    void pouvoir2()
    {
        GameObject.FindGameObjectWithTag("gauge").GetComponent<gauge>().gaugeLevel -= 0.1f;
        goCollectible = GameObject.FindGameObjectWithTag("collectible");
        Debug.Log("TUTU");

        float memY = Mathf.Infinity;
        float memX = Mathf.Infinity;

        foreach (Transform myChild in goCollectible.transform)
        {
            if(this.transform.position.x < myChild.position.x && myChild.position.x < memX)
            {
                memX = myChild.position.x;
                memY = myChild.position.y;
            }
        }
        if(memY> this.transform.position.y && memY != Mathf.Infinity)
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(0).eulerAngles = new Vector3(0, 0, 0);
        }
        else if(memX == Mathf.Infinity && memY == Mathf.Infinity)
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(0).eulerAngles = new Vector3(160,0,0);
        }
    }
}
