using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleScript : MonoBehaviour
{
    [SerializeField] GameObject RuleUI;
    [SerializeField] AudioSource AudioSource;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RuleUI.SetActive(false);
        }
    }

    public void RuleBook()
    {
        RuleUI.SetActive(true);
    }

    public void Sound()
    {
        AudioSource.Play();
    }
}
