using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float spinSpeed = 10f;
    public float speed = 0f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start() {
        rb.maxAngularVelocity = 20f;
    }
    
    private void Update() {
        speed = rb.angularVelocity.magnitude;
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            Vector2 touchDeltaPosition = touch.deltaPosition;
            float rotationAmount = touchDeltaPosition.y * spinSpeed;

            int direction;

            if(touch.position.x < Screen.width / 2){
                direction = 1;
            } else {
                direction = -1;
            }

            rb.AddTorque(transform.forward * rotationAmount * direction);
        }
    }
}
