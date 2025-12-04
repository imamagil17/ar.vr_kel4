using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCode : MonoBehaviour
{
    LineRenderer lineRenderer;

    public Transform origin;      // Titik Awal (Misal: Point 0)
    public Transform destination; // Titik Akhir (Misal: Point 1)

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.05f; // Diperkecil biar rapi
        lineRenderer.endWidth = 0.05f;

        // PENTING: Gunakan World Space supaya garis bebas bergerak
        lineRenderer.useWorldSpace = true;
    }

    void Update()
    {
        // Pastikan titik asal dan tujuan sudah diisi di Inspector
        if (origin != null && destination != null)
        {
            // Ambil posisi TERUPDATE dari bola
            lineRenderer.SetPosition(0, origin.position);
            lineRenderer.SetPosition(1, destination.position);
        }
    }
}