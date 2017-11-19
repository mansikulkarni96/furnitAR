using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeStatue : MonoBehaviour {

    public float size;
    Vector3 temp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void StatueResize(float newSize)
    {
                transform.localScale = new Vector3(newSize , newSize , newSize);
        /*
        Doesn't Work
        transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * 2f * UiSlider.current.value);
        */

        //transform.localScale = transform.localScale * (newSize * Time.deltaTime);

        /*
        this.transform.localScale += new Vector3(newSize * Time.deltaTime, size * Time.deltaTime, size * Time.deltaTime);
        size = newSize;

        if (newSize < size)
        {
            this.transform.localScale -= new Vector3(newSize * Time.deltaTime, size * Time.deltaTime, size * Time.deltaTime);
        } 
        */

    }
}
