using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    private int ring = 0;
    private void Start()
    {
        scoreText.text = "Rings: " + ring.ToString();
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Ring"))
        {
            ring++;
            Destroy(other.gameObject);
            Debug.Log(ring);
            scoreText.text = "Rings: " + ring.ToString();
        }
    }
}
