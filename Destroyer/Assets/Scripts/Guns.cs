using UnityEngine;

public class Guns : MonoBehaviour
{
    public Bullet bullet;
    public float delayShot;
    private float nextDelay;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && nextDelay < Time.time)
        {
            nextDelay = Time.time + delayShot;
            var shotPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bullet, new Vector3(shotPosition.x, shotPosition.y, 0), Quaternion.identity);
        }
    }
}
