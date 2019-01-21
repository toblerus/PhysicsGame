using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
[RequireComponent(typeof(LineRenderer))]
public class DrawLineScript : MonoBehaviour {

    [SerializeField] private EdgeCollider2D edgeCollider;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private Material lineMaterial;
    [SerializeField] private float lineWidth;

    void Start()
    {
        edgeCollider = GetComponent<EdgeCollider2D>();
        lineRenderer = GetComponent<LineRenderer>();

        var points = new Vector3[edgeCollider.points.Length];
        lineRenderer.positionCount = points.Length;
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        lineRenderer.useWorldSpace = false;
        lineRenderer.material = lineMaterial;

        for (int i = 0; i < edgeCollider.points.Length; i++)
        {
            points[i] = new Vector3(edgeCollider.points[i].x, edgeCollider.points[i].y, 0);
        }
        lineRenderer.SetPositions(points);
    }
}
