using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    // Menampung variabel untuk di tampilkan di inspector 
    [SerializeField] float Carspeed = 0.1f;
    [SerializeField] float SteerSpeed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make a new variabel for handling game object stay still if not pressed
        float speedInput = 0;
        float steerInput = 0;

        if (Keyboard.current.wKey.isPressed)
        {
            speedInput = 1;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedInput = -1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steerInput = 1;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steerInput = -1;
        }

        transform.Rotate(0, 0, SteerSpeed * steerInput);
        transform.Translate(0, Carspeed * speedInput , 0);
    }
}
