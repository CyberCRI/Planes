using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class InitMyPlayer : NetworkBehaviour
{
    int planes;
    public GameObject timerGO;

    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<orientation>().enabled = true;
            GetComponent<endLevelMulti>().enabled = true;
            Camera.main.GetComponent<camcam>().enabled = true;
            Camera.main.GetComponent<camcam>().avion = this.gameObject.transform;
            Destroy(GameObject.FindGameObjectWithTag("network").GetComponent<NetworkManagerHUD>());
        }
    }
        void Update()
    {
        if (isLocalPlayer)
        {
            planes = GameObject.FindGameObjectsWithTag("Player").Length + GameObject.FindGameObjectsWithTag("pasMoi").Length;
            if (planes > 1)
            {
                Debug.Log(planes);
                Instantiate(timerGO, Vector3.zero, Quaternion.identity);
                GetComponent<move>().enabled = true;
                GetComponent<power>().enabled = true;
                Destroy(GetComponent<InitMyPlayer>());
            }
        }
        else
        {
            transform.gameObject.tag = "pasMoi";
            Destroy(GetComponent<InitMyPlayer>());
        }
    }
}