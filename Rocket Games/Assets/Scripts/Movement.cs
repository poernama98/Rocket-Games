using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;

    [SerializeField] private float ThrustUp  = 1000f;
    [SerializeField] private float ThrustRotation = 100f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ThrustLogic();
        RotateInput();
    }

    void ThrustLogic()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up * ThrustUp * Time.deltaTime);
        }
    }

    void RotateInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateLogic(ThrustRotation);
        }
        
        else if (Input.GetKey(KeyCode.D))
        {
            RotateLogic(-ThrustRotation);
        }
    }

    void RotateLogic(float rotationSpeed )
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
