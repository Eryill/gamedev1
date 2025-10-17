using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float sideSpeed = 5.0f;
    private float horizontalInput;
    private float forwardInput;


    void Start()
    {
        
    }

    void Update(){

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, sideSpeed * horizontalInput * Time.deltaTime);

    }
}
