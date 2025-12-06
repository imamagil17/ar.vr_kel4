<br />
<div align="center">
  <img src="https://img.shields.io/badge/Unity-2021.3%2B-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity Version">
  <img src="https://img.shields.io/badge/Tech-AR%20%26%20VR-blue?style=for-the-badge" alt="AR VR">

  <h3 align="center">Tugas Besar AR/VR - Kelompok 4</h3>
  <h4 align="center">Object Recognition & Hand Tracking (Buku "Pergi")</h4>

  <p align="center">
    Pengembangan Aplikasi Augmented Reality & Virtual Reality.
  </p>
</div>

---

## 📌 Tentang Proyek

Proyek ini adalah **Tugas Besar UAS** yang dikembangkan oleh Kelompok 4. Proyek ini menggabungkan dua teknologi utama: **Object Recognition (AR)** dan **Hand Tracking (VR)**.

Fokus proyek ini adalah interaksi digital dengan objek fisik spesifik: **Buku "Pergi" karya Tere Liye**.

Aplikasi ini memiliki dua mode operasi:

1.  **Augmented Reality (AR):** Mendeteksi buku fisik "Pergi" dan menampilkan informasi digital (seperti sinopsis atau detail penulis) tepat di atasnya.
2.  **Virtual Reality (VR):** Pengguna dapat memanipulasi model 3D buku virtual secara *real-time* menggunakan gerakan tangan, di mana pelacakan tangan dilakukan melalui skrip Python dan koneksi data UDP ke Unity.

---

## 🌟 Fitur Utama

### 1. AR Mode: Buku "Pergi"
* **Deteksi Objek 3D:** Menggunakan **Vuforia Object Target** untuk mengenali bentuk dan dimensi Buku "Pergi".
* **Informasi Overlay:** Menampilkan UI interaktif dan informasi penting (sinopsis, dll.) yang melekat pada buku fisik.

### 2. VR Mode: Manipulasi Tangan (Eksternal)
* **Pelacakan Tangan:** Menggunakan solusi **Computer Vision** (Python + CV Zone/MediaPipe) dan webcam eksternal untuk mendeteksi posisi tangan.
* **Komunikasi UDP:** Mengirim data koordinat tangan secara cepat dan *real-time* ke lingkungan Unity.
* **Interaksi Virtual:** Memungkinkan pengguna untuk mengambil, memutar, dan berinteraksi dengan model 3D virtual objek menggunakan tangan mereka.

---

## 🛠 Teknologi yang Digunakan

| Komponen | Peran |
| :--- | :--- |
| **Unity 3D** | Game Engine utama untuk pengembangan AR/VR. |
| **Vuforia Engine** | SDK untuk Object Target Recognition. |
| **Python** | Host skrip Computer Vision. |
| **CV Zone & MediaPipe** | Library untuk implementasi 3D Hand Tracking. |
| **Protokol UDP** | Jembatan komunikasi data *low-latency* antara Python dan Unity. |
| **C#** | Skrip logika Unity untuk memproses data UDP dan mengontrol objek. |

---

## 🚀 Cara Menjalankan Project

### Prasyarat Wajib
* Unity Editor (Versi 2021.3 LTS).
* Android Build Support.
* **Python 3.x** (dengan paket `cvzone`, `mediapipe`, dan `socket`).
* **Buku Fisik "Pergi" karya Tere Liye** (diperlukan untuk pengujian AR).

### Langkah-langkah Pengujian
1.  **Clone Repo:** Unduh atau *clone* repositori ini.
2.  **Buka Unity:** Buka folder proyek di Unity Hub.
3.  **Siapkan Vuforia:** Masukkan App License Key di `Window > Vuforia Configuration`.
4.  **Jalankan Python:** Buka dan jalankan skrip Python Hand Tracking terlebih dahulu untuk mulai mengirim data UDP.
5.  **Jalankan Unity:** Jalankan *scene* `AR_Scene` atau `VR_Scene` di Unity. Pastikan aplikasi Unity dan skrip Python berjalan bersamaan.

---

## 👥 Tim Pengembang (Kelompok 4)

| NIM | Nama Mahasiswa | Peran Kunci |
| :--- | :--- | :--- |
| **F55123066** | **Imam Agil Aiman** | Project Leader, Lead Developer (AR/VR Logic, DevOps) |
| **F55123090** | **Isti Zahra Eka Putri Katili** | 3D Artist, UI/UX Designer, Demo Presentation |
| **F55123076** | **Muhammad Rayyan Nazmuddin** | QA/Tester, Dokumentasi Teknis |

---

## 📝 Lisensi & Kredit

Proyek ini dibuat untuk tujuan **Akademik/Edukasi** dan dilisensikan di bawah **MIT License**.

### Kredit Pihak Ketiga
Implementasi dasar Hand Tracking dan koneksi data UDP sebagian besar mengacu pada tutorial dan skrip yang disediakan secara gratis oleh **Murtaza's Workshop - Robotics and AI**.

* Lisensi *library* seperti CV Zone, MediaPipe, dan OpenCV tunduk pada ketentuan lisensi *open-source* masing-masing.

