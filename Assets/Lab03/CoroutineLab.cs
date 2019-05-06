using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineLab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintOneSec());
        StartCoroutine(PrintFiveSec());
        InvokeRepeating("PrintOneInvoke", 0.0f, 1.0f);      // Invoke는 반복하는데 정확하게 시간을 지킨다.
    }

    IEnumerator PrintOneSec()
    {
        while (true)
        {
            Debug.Log("One Second!");
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator PrintFiveSec()
    {
        while (true)
        {
            Debug.Log("Five Seconds!");
            yield return new WaitForSeconds(5.0f);
        }
    }

    void PrintOneInvoke()
    {
        Debug.Log("One Invoke!");
    }

}
