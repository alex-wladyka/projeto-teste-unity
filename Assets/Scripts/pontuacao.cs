using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pontuacao : MonoBehaviour
    
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (player.position.z>=0)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        else
        {
            scoreText.text = SceneManager.GetActiveScene().name;
        }
        
    }
}
