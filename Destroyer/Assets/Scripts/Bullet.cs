using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float minXValue;
    public float maxXValue;
    public GameObject effetBoom;
    private Vector3 direction;
    private float yDirection;
    private float xDirection;

    void Start()
    {
        xDirection = transform.position.x + Random.Range(minXValue, maxXValue);
    }

    private void Update()
    {
        yDirection = transform.position.y - 1;
        direction = new Vector3(xDirection, yDirection, 0);
        transform.position = Vector3.Lerp(transform.position, direction, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Destroyer _))
        {
            Instantiate(effetBoom, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
