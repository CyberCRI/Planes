using UnityEngine;
using System.Collections;

public class collectible : MonoBehaviour {

    public float value = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("gauge").GetComponent<gauge>().gaugeLevel += value;
            Destroy(this.gameObject);
        }
    }
}
