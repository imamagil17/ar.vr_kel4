using UnityEngine;

public class TouchBreaker : MonoBehaviour
{
    public float kekuatanLedakan = 500f; // Kekuatan dorong
    public float radiusLedakan = 3f;     // Seberapa luas ledakannya

    void Update()
    {
        // Deteksi Klik / Sentuh
        if (Input.GetMouseButtonDown(0))
        {
            Meledak();
        }
    }

    void Meledak()
    {
        // 1. Ubah posisi sentuh di layar jadi sinar laser (Ray)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // 2. Tembakkan laser!
        if (Physics.Raycast(ray, out hit))
        {
            // 3. Kalau kena sesuatu, bikin ledakan di titik itu
            Vector3 titikLedak = hit.point;

            // Cari semua benda di sekitar titik ledak
            Collider[] bendaSekitar = Physics.OverlapSphere(titikLedak, radiusLedakan);

            foreach (Collider benda in bendaSekitar)
            {
                Rigidbody rb = benda.GetComponent<Rigidbody>();

                // Kalau benda itu punya Rigidbody (bisa mental)
                if (rb != null)
                {
                    // BERI GAYA LEDAKAN!
                    // (Kekuatan, Pusat Ledakan, Radius, Gaya Angkat ke Atas)
                    rb.AddExplosionForce(kekuatanLedakan, titikLedak, radiusLedakan, 1.0f);
                }
            }
        }
    }
}