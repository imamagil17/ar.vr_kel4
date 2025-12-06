<br />
<div align="center">
  <img src="https://img.shields.io/badge/Unity-2021.3%2B-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity Version">
  <img src="https://img.shields.io/badge/Tech-AR%20%26%20VR-blue?style=for-the-badge" alt="AR VR">

  <h3 align="center">Tugas Besar AR/VR - Kelompok 4</h3>
  <h4 align="center">Object Recognition & Hand Tracking (Buku "Pergi")</h4>

  <p align="center">
    Pengembangan Aplikasi Augmented Reality & Virtual Reality.
    <br />
    <br />
  </p>
</div>

---

## 📌 Tentang Proyek

Proyek ini dibuat untuk memenuhi **Tugas Besar (Project Base) UAS** dengan menggabungkan Object Recognition (AR) dan Hand Tracking (VR). Fokus utama proyek ini adalah **Buku "Pergi" karya Tere Liye**.

Aplikasi ini memiliki dua modul utama berdasarkan tema tugas **Kelompok 4**:

1.  **Augmented Reality (Object Recognition):** Mendeteksi objek spesifik, yaitu **Buku "Pergi"**, dan memunculkan *overlay* informasi atau instruksi digital terkait buku tersebut.
2.  **Virtual Reality (Hand Tracking):** Simulasi di mana pengguna dapat memanipulasi versi virtual objek (model 3D buku) menggunakan *Hand Tracking* yang diimplementasikan melalui skrip Python dan koneksi UDP ke Unity.

---

## 🌟 Fitur Utama

### 1. AR Mode: Object Recognition pada Buku "Pergi"
Menggunakan teknologi **Vuforia Object Target** untuk mengenali buku "Pergi".
* ✅ **Deteksi Objek Spesifik:** Mengenali model 3D dari **Buku "Pergi" (Tere Liye)** sebagai target AR.
* ✅ **Info Overlay:** Menampilkan sinopsis singkat, detail penulis, atau menu interaktif digital yang muncul di atas buku fisik.

### 2. VR Mode: Virtual Manipulation (External Hand Tracking)
Memungkinkan interaksi natural dengan objek virtual menggunakan *Hand Tracking* berbasis komputer vision.
* ✅ **Hand Tracking Eksternal:** Pelacakan tangan dilakukan di Python (CV Zone/MediaPipe) menggunakan webcam eksternal.
* ✅ **UDP Communication:** Data koordinat tangan dikirim *real-time* ke Unity melalui protokol UDP.
* ✅ **Manipulasi Objek:** Pengguna dapat "mengambil" model 3D virtual dari buku dan memutarnya untuk melihat detail.

---

## 🛠 Teknologi yang Digunakan

| Komponen | Tujuan | Keterangan |
| :--- | :--- | :--- |
| **Unity 3D** | Engine Utama | Pengembangan Game/AR/VR. |
| **Vuforia Engine** | Augmented Reality | Digunakan untuk Object Target Recognition (Buku "Pergi"). |
| **Python** | Computer Vision | Digunakan untuk proses deteksi tangan. |
| **CV Zone & MediaPipe** | Library Hand Tracking | Implementasi pelacakan titik 3D tangan. |
| **UDP Protocol** | Komunikasi Data | Protokol untuk mengirim koordinat tangan dari Python ke Unity. |
| **C# Scripting** | Logika Aplikasi | Digunakan di Unity untuk memproses data UDP dan menggerakkan objek. |
| **Platform Target** | Deployment | Android (APK) dan PC (untuk running Python Script). |

---

## 🚀 Cara Menjalankan Project

### Prasyarat
* Unity Hub & Unity Editor (Versi 2021.3 LTS atau lebih baru).
* Android Build Support (SDK, NDK, JDK).
* **Python** (dengan paket `cvzone`, `mediapipe`, dan `socket`).
* **Objek Fisik:** **Buku "Pergi" karya Tere Liye** (Diperlukan untuk menguji fitur AR).

### Instalasi
1.  **Clone Repository**
    ```sh
    git clone [https://github.com/imamagil17/ar.vr_kel4.git](https://github.com/imamagil17/ar.vr_kel4.git)
    ```
2.  **Buka di Unity**
    Buka Unity Hub > Add Project > Pilih folder `ar.vr_kel4`.
3.  **Setup Vuforia**
    * Buka `Window > Vuforia Configuration`.
    * Masukkan App License Key (jika diperlukan).
4.  **Setup Python (Modul VR)**
    * Buka file Python yang berisi skrip Hand Tracking (cari file `[nama_file].py`).
    * Pastikan Anda telah menginstal semua dependency Python (terutama `cvzone` dan `mediapipe`).
    * **Jalankan Python script sebelum menjalankan Unity** untuk memulai pengiriman data UDP.

### Build ke Android
* Buka `File > Build Settings` di Unity.
* Pilih Platform **Android** > **Switch Platform**.
* Centang Scene yang relevan (`AR_Scene` dan `VR_Scene`).
* Klik **Build And Run**.

---

## 👥 Tim Pengembang (Kelompok 4)

| NIM | Nama Mahasiswa | Role / Tugas |
| :--- | :--- | :--- |
| **F55123066** | **Imam Agil Aiman** | Project Leader, Lead Developer, AR & VR Specialist, DevOps|
| **F55123090** | **Isti Zahra Eka Putri Katili** | 3D Artist, UI/UX Designer, Demo |
| **F55123076** | **Muhammad Rayyan Nazmuddin** | QA/Tester, Documentation |

---

## 📝 Lisensi

Proyek ini bersifat **Akademik/Edukasi** dan dilisensikan di bawah **MIT License**.

Anda bebas menggunakan, memodifikasi, dan mendistribusikan kode ini untuk tujuan akademis dan non-komersial.

**Catatan Lisensi Pihak Ketiga:**
Sebagian besar implementasi Hand Tracking di modul VR didasarkan pada tutorial dan skrip *UDP Receive* yang disediakan secara gratis oleh **Murtaza's Workshop - Robotics and AI**.

* Lisensi CV Zone, MediaPipe, dan OpenCV (Python libraries) tunduk pada lisensi open-source masing-masing.
* Lisensi Unity dan Vuforia tunduk pada kebijakan lisensi perusahaan masing-masing.
