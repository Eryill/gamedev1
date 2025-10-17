using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 20.0f;
    private float verticalInput;

    void Start()
    {

    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Rotate(Vector3.right, rotationSpeed * verticalInput * Time.deltaTime);
    }
}
