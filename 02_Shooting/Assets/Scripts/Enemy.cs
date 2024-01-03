using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 실습
    // 1. 적은 위아래로 파도치듯이 움직인다.
    // 2. 적은 계속 왼쪽 방향으로 이동한다.

    /// <summary>
    /// 이동 속도
    /// </summary>
    public float speed = 1.0f;

    /// <summary>
    /// 위 아래로 움직이는 정도
    /// </summary>
    public float amplitude = 3.0f;

    /// <summary>
    /// 사인 그래프가 한번 왕복하는데 걸리는 시간 증폭용
    /// </summary>
    public float frequency = 2.0f;

    /// <summary>
    /// 적이 스폰된 높이
    /// </summary>
    float spawnY = 0.0f;

    /// <summary>
    /// 전체 경과 시간(frequency에 의해 증폭됨)
    /// </summary>
    float elapsedTime = 0.0f;

    private void Start()
    {
        // 초기화
        spawnY = transform.position.y;
        elapsedTime = 0.0f;
    }

    private void Update()
    {
        //elapsedTime += Time.deltaTime;  // 시작부터 진행된 시간 측정
        elapsedTime += Time.deltaTime * frequency;  // sin 그래프의 진행을 더 빠르게 만들기

        transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, // 계속 왼쪽으로 진행
            spawnY + Mathf.Sin(elapsedTime) * amplitude,    // sin 그래프에 따라 높에 변동하기
            0.0f);
    }
}
