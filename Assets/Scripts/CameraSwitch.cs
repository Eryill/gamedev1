using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera1.SetActive(true);


        }

        if (Input.GetKeyDown(KeyCode.Keypad2)) {
            camera1.SetActive(false);
            camera3.SetActive(false);
            camera2.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
        }
    }
}
