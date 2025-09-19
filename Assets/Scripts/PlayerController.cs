using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float vehicleSpeed = 20;
    public float vehicleTurnSpeed = 10;
    public float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // We get the horizontal input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * vehicleSpeed));
        // And turn the vehicle based on the turn speed and horizontal input
        transform.Translate(Vector3.right * (Time.deltaTime * vehicleTurnSpeed * horizontalInput));
    }
}