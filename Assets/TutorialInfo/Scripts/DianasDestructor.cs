using UnityEngine;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject dianaDestruida;
    public Score scoreManager;

    private MeshRenderer meshRenderer;
    private Collider col;
    private bool destruida = false;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        col = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet") && !destruida)
        {
            destruida = true;

            scoreManager.SumarPuntos(100);

            Instantiate(
                dianaDestruida,
                transform.position,
                transform.rotation * Quaternion.Euler(90, 0, 0)
            );

            StartCoroutine(Reaparecer());
        }
    }

    IEnumerator Reaparecer()
    {
        meshRenderer.enabled = false;
        col.enabled = false;

        yield return new WaitForSeconds(3f);

        meshRenderer.enabled = true;
        col.enabled = true;
        destruida = false;
    }
}