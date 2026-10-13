using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnBullet : MonoBehaviour
{
    public GameObject Bullet;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}