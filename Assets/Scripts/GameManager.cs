using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    bool JogoTerminou = false;

    public float restartDelay = 1f;

    public GameObject UiNivelCompleto;

    public Text scoreText;

    public void CompleteLevel()
    {
        UiNivelCompleto.SetActive(true);
    }

    public void FimJogo()
    {
        if (JogoTerminou == false)
        {
            scoreText.color = Color.red;
            JogoTerminou = true;
            Debug.Log("FIM DE JOGO");
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
