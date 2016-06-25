using UnityEngine;
using System.Collections;

public class death : MonoBehaviour
{
    public float speedMalus = 4.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            other.gameObject.GetComponent<move>().speed = speedMalus;
        }
    }
}