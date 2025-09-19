using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float vehicleSpeed = 20;
    public float vehicleTurnSpeed = 25;
    public float horizontalInput;
    public float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // We get the horizontal and vertical input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * vehicleSpeed * verticalInput));

        // And turn the vehicle based on the turn speed and horizontal input
        transform.Rotate(Vector3.up * (Time.deltaTime * vehicleTurnSpeed * horizontalInput));
    }
}