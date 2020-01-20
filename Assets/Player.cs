using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip("In ms^-1")][SerializeField] float xSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        //print("START");
    }

    // Update is called once per frame
    void Update()
    {
        // left and right movement (horizontal) across the screen of the ship
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffsetThisFrame = xThrow * xSpeed * Time.deltaTime;
        print(xOffsetThisFrame);
    }
}
