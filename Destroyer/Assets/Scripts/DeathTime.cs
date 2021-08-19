using UnityEngine;

public class DeathTime : MonoBehaviour
{
    public float time;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
