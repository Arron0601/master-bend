using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine;


public class buttontest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    IEnumerator CoroutineA()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//滑鼠左鍵
        {
            StartCoroutine(CoroutineA());
        }
    }
}
            
    