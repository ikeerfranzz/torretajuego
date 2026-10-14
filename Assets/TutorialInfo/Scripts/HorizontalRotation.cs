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
        RaycastHit hit;
        Debug.DrawRay(transform.position, -transform.up * distance, Color.red);
        transform.localEulerAngles += new Vector3(0,
            Mouse.current.delta.value.x, 0) * rotationSpeed;
        if (Physics.Raycast(transform.position, -transform.up, out hit, distance))
        {
            Debug.DrawRay(transform.position, -transform.up * hit.distance, Color.green);
        }
        else
        {
            hitPosition = transform.position - transform.up * distance;
        }
    }
        private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, 0.1f);
        Gizmos.DrawSphere(hitPosition, 0.1f);
    }
}

