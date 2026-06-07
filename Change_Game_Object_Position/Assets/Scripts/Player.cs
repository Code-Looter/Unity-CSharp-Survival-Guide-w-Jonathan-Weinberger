using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables
    // create a vector3 variable called startPosition
    public Vector3 startPosition;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Player_Position();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Player_Position()
    {
        startPosition = new Vector3(10, 10, 10);
        transform.position = startPosition;
    }

} // Main
