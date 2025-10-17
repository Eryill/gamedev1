using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    
    void Start()
    {

        
    }

    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // new Vector3 (offset.x, offset.y, -offset.z); per invertire il valore z
    }
}
