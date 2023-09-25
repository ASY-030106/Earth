using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsMove : MonoBehaviour
{
    public Transform cylinderTransform; // Cylinder 오브젝트의 Transform 컴포넌트
    public GameObject projectilePrefab; // 발사할 프로젝타일의 프리팹
    public Camera mainCamera; // 메인 카메라

    public float rotationSpeed = 50.0f; // 회전 속도
    public float positionChangeSpeed = 0.5f; // Position 변경 속도
    public float rotationZChangeSpeed = 10.0f; // Rotation Z 변경 속도
    public float projectileSpeed = 10.0f; // 발사 속도

    private bool isObjectMoving = false;

    private void Update()
    {
        // W와 S 키를 사용하여 rotation의 x를 조절합니다.
        float rotationX = cylinderTransform.localEulerAngles.x;
        rotationX -= Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        cylinderTransform.localEulerAngles = new Vector3(rotationX, cylinderTransform.localEulerAngles.y, cylinderTransform.localEulerAngles.z);

        // D 키를 누를 때 position x를 0.5씩 증가시키고 rotation z를 10씩 감소시킵니다.
        if (Input.GetKeyDown(KeyCode.D))
        {
            cylinderTransform.position += new Vector3(positionChangeSpeed, 0, 0);
            cylinderTransform.Rotate(0, 0, -rotationZChangeSpeed * Time.deltaTime);
        }

        // A 키를 누를 때 position x를 0.5씩 감소시키고 rotation z를 10씩 증가시킵니다.
        if (Input.GetKeyDown(KeyCode.A))
        {
            cylinderTransform.position -= new Vector3(positionChangeSpeed, 0, 0);
            cylinderTransform.Rotate(0, 0, rotationZChangeSpeed * Time.deltaTime);
        }

        // 스페이스 바를 누를 때 오브젝트를 발사하고 이동을 시작합니다.
        if (Input.GetKeyDown(KeyCode.Space) && !isObjectMoving)
        {
            // 발사 방향을 카메라의 forward 방향으로 설정합니다.
            Vector3 projectileDirection = mainCamera.transform.forward;

            // 현재 rotation 각도를 반영합니다.
            projectileDirection = Quaternion.Euler(cylinderTransform.eulerAngles) * projectileDirection;

            // 프로젝타일을 생성하고 초기 속도를 설정합니다.
            GameObject projectile = Instantiate(projectilePrefab, cylinderTransform.position, Quaternion.identity);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = projectileDirection.normalized * projectileSpeed;
            }

            isObjectMoving = true;

            // 10초 후에 이동을 중지합니다.
            Invoke("StopObjectMovement", 10.0f);
        }
    }

    private void StopObjectMovement()
    {
        isObjectMoving = false;
    }
}
