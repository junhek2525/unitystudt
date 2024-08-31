using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;      // 플레이어의 Transform을 연결할 변수
    public Vector3 offset;        // 카메라와 플레이어 간의 오프셋을 설정할 변수
    public float smoothSpeed = 0.125f; // 카메라 이동의 부드러움 정도를 설정할 변수

    private void LateUpdate()
    {
        // 플레이어의 현재 위치에 오프셋을 더해 목표 위치를 계산
        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);

        // 현재 카메라 위치와 목표 위치 간의 차이를 부드럽게 보간하여 카메라를 이동
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 카메라의 위치를 부드럽게 이동
        transform.position = smoothedPosition;
    }
}












/*using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    
    
    
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        this.player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}*/
