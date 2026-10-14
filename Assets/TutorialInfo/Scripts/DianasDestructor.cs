using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject dianaDestruida;
    public Score scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            scoreManager.SumarPuntos(100);

            Instantiate(
                dianaDestruida,
                transform.position,
                transform.rotation * Quaternion.Euler(90, 0, 0)
            );

            gameObject.SetActive(false);
            WaitForSeconds(3f);
        }
    }
}