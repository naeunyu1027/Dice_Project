using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class GameOut : MonoBehaviour
{
    [SerializeField] GameObject gameOut;
    [SerializeField] bool gameOutActive;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !gameOutActive)
        {
            gameOut.SetActive(true);
            gameOutActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && gameOutActive)
        {
            gameOut.SetActive(false);
            gameOutActive = false;
        }
    }

    public void ExitGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;  // 에디터에서 실행 중지
#else
        Application.Quit();  // 빌드된 게임 종료
#endif
    }

    public void OutGame()
    {
        Invoke("ExitGame", 1.5f);
    }

    public void LobyBack()
    {
        Invoke("LobySound", 1.5f);
    }

    public void LobySound()
    {
        SceneManager.LoadScene(0);
    }
    
}
