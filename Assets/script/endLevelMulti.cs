using UnityEngine;
using System.Collections;

public class endLevelMulti : MonoBehaviour {

    public GameObject menuGO;
    public Canvas can;

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.FindGameObjectWithTag("Player").transform.position.x > 900)
        {
            GameObject go =  GameObject.FindWithTag("timer") as GameObject;
            go.GetComponent<timer>().end();
            Instantiate(menuGO, Vector3.zero, Quaternion.identity);
            Instantiate(can, Vector3.zero, Quaternion.identity);
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }
}
