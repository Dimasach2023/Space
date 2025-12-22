using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int rotationSpeed = 60;
    private int speed = 10;
    private float vertical;
    private float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * vertical);
    }
}
