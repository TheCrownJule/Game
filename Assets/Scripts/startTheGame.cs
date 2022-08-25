using UnityEngine;
using UnityEngine.SceneManagement;

public class startTheGame : MonoBehaviour
{
    public void startGameNow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
