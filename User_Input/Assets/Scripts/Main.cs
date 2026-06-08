using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // In this section of the course.
    // We learn about user input.

    #region Variables

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        User_Input();
    }


    private void User_Input()
    {
        // If space key is presed down
        // print a message
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("The Space Bar was pressed");
        }

        // if e key is held down
        // print message

        if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }

        // If f key is lifted up
        // print f

        if(Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F was pressed up");
        }
    }
} // Main Function
