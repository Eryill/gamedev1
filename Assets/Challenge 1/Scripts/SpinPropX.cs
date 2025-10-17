using UnityEngine;

public class SpinPropX : MonoBehaviour
{
    public float rotationprop = 1000.0f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(Vector3.forward * rotationprop * Time.deltaTime);
    }
}
