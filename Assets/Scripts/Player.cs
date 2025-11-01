using UnityEngine;
using UnityEngine.InputSystem;



public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float force;
    [SerializeField] private GameManager gm;
  

    
    bool alive = true;

   

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            if (Keyboard.current[Key.Space].wasPressedThisFrame)
            {
                rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            }
        }
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (alive)
        {
            if (other.CompareTag("PipeEntered"))
            {
                gm.UpdateScore(1);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (alive)
        {
            if (collision.collider.CompareTag("PipeBumped"))
            {
                alive = false;
                gm.GameOver();
            }
        }
    }
}
