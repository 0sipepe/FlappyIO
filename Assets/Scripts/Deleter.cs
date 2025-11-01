using UnityEngine;

public class Deleter : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PipeEntered"))
        {
            Destroy(other.gameObject);
        }
    }
}
