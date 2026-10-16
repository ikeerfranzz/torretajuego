using UnityEngine;
using UnityEngine.InputSystem;

public class HorizontalRotation : MonoBehaviour
{
    Vector3 hitPosition;
    public float rotationSpeed = 1;
    public float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0,
            Mouse.current.delta.value.x, 0) * rotationSpeed;

    }
}

