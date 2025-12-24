using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int currentLevel = 0;
    void Update()
    {
        if(CheckRings())
        {
            currentLevel++;
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
        SceneManager.LoadScene(currentLevel);
    }
}
