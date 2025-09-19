using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    // Vehicle speed in units per second
    private const float VehicleSpeed = 20;

    // Vehicle turn speed in degrees per second
    private const float VehicleTurnSpeed = 25;

    // Variables to store player input
    private float _horizontalInput;
    private float _verticalInput;

    // Update is called once per frame
    void Update()
    {
        // We get the horizontal and vertical input from the player
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle based on the vertical input
        transform.Translate(Vector3.forward * (Time.deltaTime * VehicleSpeed * _verticalInput));

        // And turn the vehicle based on the turn speed and horizontal input
        transform.Rotate(Vector3.up * (Time.deltaTime * VehicleTurnSpeed * _horizontalInput));
    }
}