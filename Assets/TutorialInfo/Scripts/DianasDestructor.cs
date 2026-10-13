using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject dianaDestruida;
    public float score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            score += 100;
            Instantiate(dianaDestruida, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0));
        }
    }
}
