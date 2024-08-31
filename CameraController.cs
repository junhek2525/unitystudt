using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;      // �÷��̾��� Transform�� ������ ����
    public Vector3 offset;        // ī�޶�� �÷��̾� ���� �������� ������ ����
    public float smoothSpeed = 0.125f; // ī�޶� �̵��� �ε巯�� ������ ������ ����

    private void LateUpdate()
    {
        // �÷��̾��� ���� ��ġ�� �������� ���� ��ǥ ��ġ�� ���
        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);

        // ���� ī�޶� ��ġ�� ��ǥ ��ġ ���� ���̸� �ε巴�� �����Ͽ� ī�޶� �̵�
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // ī�޶��� ��ġ�� �ε巴�� �̵�
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
