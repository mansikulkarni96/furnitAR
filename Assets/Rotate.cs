using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

#if UNITY_ANDROID || UNITY_IOS

    float moveSpeed;
    // Use this for initialization
    void Start () {
        moveSpeed = 5f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            //Store input
            Touch fing = Input.GetTouch(0);
            if (fing.phase == TouchPhase.Moved)
            {  //If the finger has moved since the last frame
                //Find the amount of finger movement, and apply a rotation to this gameobject based on that amount
                Vector3 rotation = transform.localRotation.eulerAngles;
                Vector2 fingMove = fing.deltaPosition;
                float deltaY = fingMove.x * moveSpeed * Time.deltaTime*2;
                rotation.y -= deltaY;
                this.transform.localRotation = Quaternion.Euler(rotation);
            }
        }
    }
#endif
}
