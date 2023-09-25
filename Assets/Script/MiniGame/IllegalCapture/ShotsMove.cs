using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsMove : MonoBehaviour
{
    public Transform cylinderTransform; // Cylinder ������Ʈ�� Transform ������Ʈ
    public GameObject projectilePrefab; // �߻��� ������Ÿ���� ������
    public Camera mainCamera; // ���� ī�޶�

    public float rotationSpeed = 50.0f; // ȸ�� �ӵ�
    public float positionChangeSpeed = 0.5f; // Position ���� �ӵ�
    public float rotationZChangeSpeed = 10.0f; // Rotation Z ���� �ӵ�
    public float projectileSpeed = 10.0f; // �߻� �ӵ�

    private bool isObjectMoving = false;

    private void Update()
    {
        // W�� S Ű�� ����Ͽ� rotation�� x�� �����մϴ�.
        float rotationX = cylinderTransform.localEulerAngles.x;
        rotationX -= Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        cylinderTransform.localEulerAngles = new Vector3(rotationX, cylinderTransform.localEulerAngles.y, cylinderTransform.localEulerAngles.z);

        // D Ű�� ���� �� position x�� 0.5�� ������Ű�� rotation z�� 10�� ���ҽ�ŵ�ϴ�.
        if (Input.GetKeyDown(KeyCode.D))
        {
            cylinderTransform.position += new Vector3(positionChangeSpeed, 0, 0);
            cylinderTransform.Rotate(0, 0, -rotationZChangeSpeed * Time.deltaTime);
        }

        // A Ű�� ���� �� position x�� 0.5�� ���ҽ�Ű�� rotation z�� 10�� ������ŵ�ϴ�.
        if (Input.GetKeyDown(KeyCode.A))
        {
            cylinderTransform.position -= new Vector3(positionChangeSpeed, 0, 0);
            cylinderTransform.Rotate(0, 0, rotationZChangeSpeed * Time.deltaTime);
        }

        // �����̽� �ٸ� ���� �� ������Ʈ�� �߻��ϰ� �̵��� �����մϴ�.
        if (Input.GetKeyDown(KeyCode.Space) && !isObjectMoving)
        {
            // �߻� ������ ī�޶��� forward �������� �����մϴ�.
            Vector3 projectileDirection = mainCamera.transform.forward;

            // ���� rotation ������ �ݿ��մϴ�.
            projectileDirection = Quaternion.Euler(cylinderTransform.eulerAngles) * projectileDirection;

            // ������Ÿ���� �����ϰ� �ʱ� �ӵ��� �����մϴ�.
            GameObject projectile = Instantiate(projectilePrefab, cylinderTransform.position, Quaternion.identity);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = projectileDirection.normalized * projectileSpeed;
            }

            isObjectMoving = true;

            // 10�� �Ŀ� �̵��� �����մϴ�.
            Invoke("StopObjectMovement", 10.0f);
        }
    }

    private void StopObjectMovement()
    {
        isObjectMoving = false;
    }
}
