using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startSpeed = 6f;
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
        rb.linearVelocity = Vector2.zero;

        //Satunnainen x-suunta ylöspäin
        Vector2 dir = new Vector2(Random.Range(-0.7f, 0.7f) , 1f).normalized;

        rb.linearVelocity = dir * startSpeed;
    }
}
