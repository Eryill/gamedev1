using UnityEngine;

public class npcVehicle : MonoBehaviour
{
    public float carSpeed = 20.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);
    }
}
