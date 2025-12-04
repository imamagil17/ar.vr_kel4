using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;

    // --- PENGATURAN POSISI (Bisa diatur di Inspector) ---
    public float scale = 100f; // Semakin besar, gerakan tangan semakin kecil
    public float depth = 10f;  // Jarak tangan dari kamera (Maju/Mundur)
    public float offsetX = 0f; // Geser Kiri/Kanan manual
    public float offsetY = 0f; // Geser Atas/Bawah manual

    void Update()
    {
        string data = udpReceive.data;

        if (string.IsNullOrEmpty(data)) return;

        // Bersihkan data
        data = data.Replace("[", "").Replace("]", "").Trim();
        string[] points = data.Split(',');

        if (points.Length < 63) return;

        for (int i = 0; i < 21; i++)
        {
            try
            {
                // Baca data mentah dari Python
                float x = float.Parse(points[i * 3], CultureInfo.InvariantCulture);
                float y = float.Parse(points[i * 3 + 1], CultureInfo.InvariantCulture);
                float z = float.Parse(points[i * 3 + 2], CultureInfo.InvariantCulture);

                // --- RUMUS KALIBRASI POSISI ---

                // 1. Pusatkan (Kamera laptop 1280x720, jadi tengahnya 640x360)
                // 2. Balik X supaya seperti cermin (Mirror)
                // 3. Balik Y karena Unity Y-nya ke atas, Python Y-nya ke bawah

                float unityX = (640 - x) / scale;
                float unityY = (y - 360) / scale;
                float unityZ = z / scale;

                // Terapkan ke Bola
                // Ditambah 'depth' supaya muncul DI DEPAN kamera (bukan di dalam mata)
                handPoints[i].transform.localPosition = new Vector3(
                    -unityX + offsetX,
                    unityY + offsetY,
                    unityZ + depth
                );
            }
            catch (System.Exception e)
            {
                // Skip error
            }
        }
    }
}