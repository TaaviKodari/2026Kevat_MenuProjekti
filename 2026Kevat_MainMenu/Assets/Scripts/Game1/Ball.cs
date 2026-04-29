using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Launch();
    }

    public void Launch()
    {
        rb.linearVelocity = Vector2.up * 100;
    }
}
