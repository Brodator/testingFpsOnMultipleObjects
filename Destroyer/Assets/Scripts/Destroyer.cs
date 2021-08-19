using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject effectsBoom;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Bullet _))
        {
            Instantiate(effectsBoom, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
