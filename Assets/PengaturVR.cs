using UnityEngine;

public class PengaturVR : MonoBehaviour
{
    public GameObject objBuku;
    public GameObject objMouse;
    public GameObject objRubik;

    void Start()
    {
        string benda = PlayerPrefs.GetString("BendaTerpilih");

        // Matikan semua dulu biar aman
        objBuku.SetActive(false);
        objMouse.SetActive(false);
        objRubik.SetActive(false);

        // Nyalakan sesuai pesanan
        if (benda == "buku")
        {
            objBuku.SetActive(true);
        }
        else if (benda == "mouse")
        {
            objMouse.SetActive(true);
        }
        else if (benda == "rubik")
        {
            objRubik.SetActive(true);
        }
    }
}