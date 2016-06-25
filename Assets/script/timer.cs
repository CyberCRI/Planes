using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

    float time;
    public bool isCounting;

    float timerMin;
    float timerSec;

    // Use this for initialization
    void Start () {
        time = 0;
        isCounting = true;
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	    if(isCounting)
        {
            time += Time.deltaTime;
        }
	}

    void OnLevelWasLoaded(int lvlNum)
    {
        if(isCounting == false && lvlNum !=3)
        {
            Destroy(this.gameObject);
        }
    }

    public void end()
    {
        isCounting = false;
        timerMin = Mathf.Floor(time / 60);
        timerSec = time - 60 * timerMin;
        time = 0;
    }

    void OnGUI()
    {
        if (!isCounting)
        {
            GUI.Label(new Rect(10, 250, 1000, 1000), "Congrats, you made it in " + timerMin + " min and " + Mathf.Round(timerSec) + " sec");
        }
    }
}
