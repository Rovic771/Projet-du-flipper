using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] KeyCode menuKey = KeyCode.Escape;
    [SerializeField] bool menuOpen;
    [SerializeField] GameObject Monitor;
    [SerializeField] Animation cameraAnimation;

    private void Update()
    {
        OpenCloseMenu();
    }

    public void OpenCloseMenu()
    {
        if (Input.GetKeyDown(menuKey))
        {
            // inverse état du menu
            menuOpen = !menuOpen;

            // active/désactive le menu
            menu.SetActive(menuOpen);
            Monitor.SetActive(!Monitor.active);

            // met en pause/reprend le jeu
            Time.timeScale = menuOpen ? 0 : 1;
        }
    }

    public void ReloadScene()
    {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

	public void PlayButton()
    {
        // joue l'animation camera
        cameraAnimation.Play();
    }

    public void Quit()
    {
        // quitte le jeu
        Application.Quit();
    }


}
