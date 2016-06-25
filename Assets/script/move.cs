using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float gravity;
    float trueSpeed;
    public float speed;

    // Use this for initialization
    void Start () {
        gravity = 5f;
        speed = 10f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
        if (this.transform.eulerAngles.z > -1 && this.transform.eulerAngles.z < 180)
        {
            if (speed > 5)
            {
                speed -= 0.01f;
            }
            
        }
        else if (this.transform.eulerAngles.z > 180 && this.transform.eulerAngles.z < 360)
        {
            if (speed < 15)
            {
                speed += 0.01f;
            }
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "wind")
        {
            transform.Translate(coll.gameObject.transform.right * Time.deltaTime * 4, Space.World);

            if(Mathf.Abs(this.transform.eulerAngles.z- coll.gameObject.transform.eulerAngles.z) < 5)
            {
                speed += 0.01f;
            }
        }
    }

}