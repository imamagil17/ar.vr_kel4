using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public string namaBenda = "buku";

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit bendaYangKena;

            if (Physics.Raycast(laser, out bendaYangKena))
            {
                // --- INI PERINTAH PENTING ---
                Debug.Log("SAYA MENABRAK: " + bendaYangKena.transform.name);
                // ---------------------------

                if (bendaYangKena.transform == transform)
                {
                    PlayerPrefs.SetString("BendaTerpilih", namaBenda);
                    SceneManager.LoadScene("FIX");
                }
            }
        }
    }
}