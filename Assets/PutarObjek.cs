using UnityEngine;

public class PutarObjek : MonoBehaviour
{
    // "public" artinya angka ini akan muncul di Inspector Unity
    // Bisa kamu ganti jadi 10, 50, atau 100 kalau kurang cepat
    public float kecepatanPutar = 20f;

    void Update()
    {
        // Cek apakah Klik Kiri Mouse DITAHAN
        if (Input.GetMouseButton(0))
        {
            // Ambil gerakan mouse (Kali dengan Time.deltaTime supaya mulus di semua HP)
            float rotasiX = Input.GetAxis("Mouse X") * kecepatanPutar;
            float rotasiY = Input.GetAxis("Mouse Y") * kecepatanPutar;

            // Memutar Objek
            // Sumbu Y (Atas/Bawah) diputar oleh gerakan Mouse X (Kiri/Kanan)
            // Sumbu X (Kiri/Kanan) diputar oleh gerakan Mouse Y (Atas/Bawah)
            transform.Rotate(Vector3.down, rotasiX, Space.World);
            transform.Rotate(Vector3.right, rotasiY, Space.World);
        }
    }
}