using UnityEngine;

public class LetterTracer : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private bool isTracing = false;

    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = Color.green;
        lineRenderer.endColor = Color.green;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTracing = true;
            lineRenderer.positionCount = 0;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isTracing = false;
        }

        if (isTracing)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            if (lineRenderer.positionCount == 0 || Vector3.Distance(lineRenderer.GetPosition(lineRenderer.positionCount - 1), mousePos) > 0.05f)
            {
                lineRenderer.positionCount++;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, mousePos);
            }
        }
    }
}
