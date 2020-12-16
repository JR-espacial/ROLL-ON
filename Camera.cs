using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ball;
    public float smoothSpeed = 0.125f;
    float ballX, ballY;

    void Start()
    {
        ballX = ball.position.x;
        ballY = ball.position.y;
    }
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(ballX, ballY, ball.position.z - 10f);
        transform.position = desiredPosition;
    }
}
