using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float impulso = 20f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * impulso, ForceMode.Impulse);
    }
}