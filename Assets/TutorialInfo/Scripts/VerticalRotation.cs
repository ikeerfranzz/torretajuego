using UnityEngine;
using UnityEngine.InputSystem;

public class VerticalRotation : MonoBehaviour
{
    public float rotationSpeed = 1;

    void Update()
    {
        transform.localEulerAngles += new Vector3(
            0,
            0,
            Mouse.current.delta.value.y
        ) * rotationSpeed;
    }
}