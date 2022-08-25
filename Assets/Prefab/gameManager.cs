using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restartGame", restartDelay);
            
        }
       
    }

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
