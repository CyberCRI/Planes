using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour {

    public GameObject timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameObject.FindGameObjectWithTag("Player").transform.position.x>900)
        {
            timer.GetComponent<timer>().end();
            SceneManager.LoadScene(3);
        }
	}
}
