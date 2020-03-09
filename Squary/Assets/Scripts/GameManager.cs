using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = true;

    public float restartDelay = 0f;

    public void Restart()
    {
        ShopController.coinAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void EndGame()
    {
        if (GameHasEnded == true)
        {
            Debug.Log("Game Over!");
            ShopController.coinAmount = 0;
            Invoke("Restart", restartDelay);
        }
        GameHasEnded = false;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


     

}
