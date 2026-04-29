using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8f;


    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        //Debug.Log(input);
        Vector3 pos = transform.position;
        pos.x += input * speed * Time.deltaTime;
        transform.position = pos;
    }
}
