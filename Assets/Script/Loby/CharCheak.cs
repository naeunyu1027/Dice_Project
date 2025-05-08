using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCheak : MonoBehaviour
{
    [SerializeField] private Transform CharacterPosition;
    [SerializeField] private GameObject Char;
    [SerializeField] private bool TF;
    [SerializeField] private int Count;
    void Start()
    {
        
    }

    void Update()
    {
        if (!Char.activeSelf)
        {
            Vector3 center = CharacterPosition.position;
            Vector3 size = CharacterPosition.localScale;

            float x = Random.Range(center.x - size.x / 2f, center.x + size.x / 2f);
            float y = Random.Range(center.y - size.y / 2f, center.y + size.y / 2f);

            Vector3 spawnPos = new Vector3(x, y, Char.transform.position.z); // Z는 고정 (2D일 경우)

            Char.transform.position = spawnPos;
            /*Char.GetComponent<Transform>().position = CharacterPosition.position;*/
            if (!TF)
            {
                TF = true;
                StartCoroutine(SpawnP());
                
            }
        }
    }
    
    IEnumerator SpawnP()
    {
        Count = Random.Range(2, 15);
        yield return new WaitForSeconds(Count);
        TF = false;
        Char.SetActive(true);
    }
}
