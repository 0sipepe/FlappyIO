using UnityEngine;
using UnityEngine.InputSystem;

public class CubeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.Space].isPressed)
        {
            Time.timeScale = .1f;
        }
    }
}
