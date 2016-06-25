using UnityEngine;
using System.Collections;

public class gauge : MonoBehaviour {

    float _gaugeLevel;

    public float gaugeLevel
    {
        get
        {
            return _gaugeLevel;
        }
        set
        {
            if (value < 0)
            {
                _gaugeLevel = 0;
            }
            else if (value > 9.77f)
            {
                _gaugeLevel = 9.77f;
            }
            else
            {
                _gaugeLevel = value;
            }
        }
    }

    // Use this for initialization
    void Start ()
    {
        _gaugeLevel = 9.77f;

    }
	
	// Update is called once per frame
	void Update () {
	    if(this.transform.localScale.x < _gaugeLevel)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x+0.1f, 0.8f,1);
        }
        else if (this.transform.localScale.x > _gaugeLevel)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x - 0.1f, 0.8f, 1);
        }
    }
}
