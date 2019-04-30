using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab01 : MonoBehaviour
{
    [SerializeField] private Transform GenPosition;

    /// <summary>
    /// FixedUpdate는 Update보다 매 프레임마다 호출되는 간격이 어느정도 보장되어서
    /// 입출력이나 물리 관련 코드를 적을 때 많이 씀.
    /// </summary>
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var ball = Resources.Load<GameObject>("Lab01/Ball");        /// 프리팹 로드
            Instantiate(ball, GenPosition);                                 /// 로드한 프리팹을 월드에 생성함
        }

    }
}
