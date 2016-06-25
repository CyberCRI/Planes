using UnityEngine;
using System.Collections;

public class camcam : MonoBehaviour {

    public Transform avion;
    public float camX = 7;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (avion != null)
        {
            if (avion.position.y < this.transform.position.y - 1f)
            {
                this.transform.position = new Vector3(this.transform.position.x, avion.position.y + 1f, -10);
            }
            else if (avion.position.y > this.transform.position.y + 1f)
            {
                this.transform.position = new Vector3(this.transform.position.x, avion.position.y - 1f, -10);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
            }
            if (avion.position.x + camX > this.transform.position.x)
            {
                this.transform.position = new Vector3(avion.position.x + camX, this.transform.position.y, -10);
            }

            if (camX < 7)
            {
                Camera.main.GetComponent<camcam>().camX += 0.1f;
            }
        }
    }
}
