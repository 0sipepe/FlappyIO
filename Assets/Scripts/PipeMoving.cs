using UnityEngine;

public class PipeMoving : MonoBehaviour
{

    [SerializeField] private static float speed = 5;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

       
    }
    private void OnDestroy()
    {
        speed += 0.2f;
    }

}
