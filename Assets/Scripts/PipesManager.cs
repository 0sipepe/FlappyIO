using Unity.VisualScripting;
using UnityEngine;

public class PipesManager : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float coolDown;
    [SerializeField] private float pipesShift;

    private float timeElapsed = 0;
    private float coolDownMaximum;
    private float pipesShiftMaximum;



    // Update is called once per frame
    void Update()
    {

        timeElapsed += Time.deltaTime;
        if (timeElapsed > coolDown)
        {
            Instantiate(pipe,
                new Vector3(transform.position.x, transform.position.y + Random.Range(-pipesShift, pipesShift), transform.position.z),
                Quaternion.identity, transform);

            if (coolDown >= 1)
            {
                coolDown -= 0.05f;
                pipesShift += 0.1f;
            }

            timeElapsed = 0;
        }


    }
}
