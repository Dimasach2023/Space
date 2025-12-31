using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int rotationSpeed = 60;
    private int speed = 16;
    private float vertical;
    private float horizontal;
    public GameObject gameOverScreen;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * vertical);
        
        if(transform.position.z <= 3370)
        {
            gameOverScreen.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            gameOverScreen.SetActive(true);
        }
    }
}
