using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsLab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("IsFirst"))
        {
            Debug.Log("처음 실행 아님!");
        }
        else
        {
            PlayerPrefs.SetInt("IsFirst", 1);
            PlayerPrefs.Save();
            Debug.Log("처음 실행임!");
        }
    }
}
