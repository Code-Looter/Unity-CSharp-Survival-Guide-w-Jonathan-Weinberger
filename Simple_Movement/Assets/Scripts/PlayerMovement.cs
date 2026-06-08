using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // In this lesson we are going to create
    // a minimalistic player movement

    #region Variables
    [SerializeField] private float _speed;
    [SerializeField] private float _horizontalInput;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement_Input();
 
    }

    private void PlayerMovement_Input()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
    }

} // Main
