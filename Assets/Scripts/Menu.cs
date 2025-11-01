using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button btnReloadGame;
    
   

    private void Start()
    {

        btnReloadGame.onClick.AddListener(ReloadGame);
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
