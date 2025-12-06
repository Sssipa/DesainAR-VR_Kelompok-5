using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [Header("Pengaturan Putaran")]
    public float speed = 50f;

    public Vector3 rotationAxis = new Vector3(0, 1, 0); 

    void Update()
    {
        transform.Rotate(rotationAxis * speed * Time.deltaTime);
    }
}