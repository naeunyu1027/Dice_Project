using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        Invoke("OnClick2", 1.5f);
    }

    public void OnClick2()
    {
        SceneManager.LoadScene(1);
    }

    public void Sound()
    {
        audioSource.Play();
    }
}
