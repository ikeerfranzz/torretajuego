using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject dianaDestruida;
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
            Instantiate(dianaDestruida,transform.position,transform.rotation);
        }
    }
}
