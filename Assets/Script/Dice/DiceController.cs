using System;
using UnityEngine;
    using System.Collections;
    using Random = UnityEngine.Random;

    public class DiceController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 diceVelocity;
    public bool diceCheck = false;
    public bool FEC;
    public GameObject CardManager;
    [SerializeField] private AudioSource diceSound;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        /*if (diceCheck == null)
        {
            diceSound = GetComponent<AudioSource>();
        }*/
    }

    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space) && !diceCheck)
        {
            diceCheck = true;
            GameManager.Instance.diceNumber = 0;

            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);

            transform.position = new Vector3(0, 2, 0);
            transform.rotation = Quaternion.identity;

            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            rb.AddForce(Vector3.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);

            if(!FEC) StartCoroutine(CheckDiceStopped());
            else if (FEC)
            {
                StartCoroutine(EventSelect.instance.FightEvent());

            }
            
        }
    }

    IEnumerator CheckDiceStopped()
    {
        // 일정 시간 기다렸다가 상태 체크
        yield return new WaitForSeconds(2f);

        // 멈출 때까지 반복 체크
        while (rb.velocity.magnitude > 0.1f || rb.angularVelocity.magnitude > 0.1f)
        {
            yield return null; // 한 프레임 대기
        }

        Debug.Log("오브젝트 멈춤");
        yield return new WaitForSeconds(2.5f);
        CardManager.GetComponent<CardManager>().Cardspawn();

        yield return new WaitForSeconds(3f);
        CardManager.GetComponent<CardManager>().Cardspawn2();
        yield return new WaitForSeconds(1f);

        diceCheck = false;
        FEC = true;
        // Debug.Log("코루틴 끝남");
    }

    private void OnCollisionEnter(Collision other)
    {
            diceSound.Play(); // 충돌 시 사운드 재생
    }
}