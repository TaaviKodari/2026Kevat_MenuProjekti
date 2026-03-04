using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    public float angle = 10f;
    public float speed = 2f;


    // Update is called once per frame
    void Update()
    {
        float tilt = Mathf.Sin(Time.time *speed) * angle;
        //Debug.Log(tilt);
        transform.localRotation = Quaternion.Euler(0,0,tilt);
    }
}
