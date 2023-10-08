using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectContinent : MonoBehaviour
{
    public Camera mainCamera;
    private float zoomSpeed;
    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private bool isZoomIn = false;
    void Start()
    {
        originalPosition = mainCamera.transform.position;
        Debug.Log("Target Position: " + targetPosition);
        Debug.Log("Camera Position: " + mainCamera.transform.position);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Continent"))
                {
                    zoomSpeed = 3f;
                    targetPosition = new Vector3(hit.point.x, hit.point.y + 10, hit.point.z - 10);
                    isZoomIn = true;
                }
                else
                {
                    isZoomIn = false;
                }
            }
            else
            {
                zoomSpeed = 10f;
                targetPosition = originalPosition;
                isZoomIn = true;
            }
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 0.5f);
        }

        if (isZoomIn)
        {
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPosition, Time.deltaTime * zoomSpeed);
        }
    }
}
