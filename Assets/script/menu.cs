using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class menu : MonoBehaviour {

    public Texture solo;

    public Texture multi;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 300, 200), solo))
        {
            NetworkServer.DisconnectAll();
            SceneManager.LoadScene(1);
        }
            

        if (GUI.Button(new Rect(350, 10, 300, 200), multi))
        {
            NetworkServer.DisconnectAll();
            SceneManager.LoadScene(2);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
