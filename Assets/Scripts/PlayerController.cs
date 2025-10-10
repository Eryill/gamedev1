using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update(){
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
        
    }
}
