
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool end_screen = false;

    void Start()
    {
        end_screen = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }
        if (end_screen)
        {
            Pause();
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
