using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int currentLevel = 0;
    void Update()
    {
        if(CheckRings())
        {
            NextLevel();
        }
    }
    bool CheckRings()
    {
        GameObject[] rings = GameObject.FindGameObjectsWithTag("Ring");
        return rings.Length == 0;
    }   
    void NextLevel()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(currentLevel);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}

    