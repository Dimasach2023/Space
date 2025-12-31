using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private GameObject[] rings;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    private int ring;
    public static int countRings = 0;
    private void Start()
    {
        rings = GameObject.FindGameObjectsWithTag("Ring");
        ring = rings.Length;
        scoreText.text = ring.ToString();
        bestScoreText.text = countRings.ToString();
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Ring"))
        {
            countRings++;
            ring--;
            Destroy(other.gameObject);
            scoreText.text = ring.ToString();
            bestScoreText.text = countRings.ToString();
        }
    }
}
