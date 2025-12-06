# AR Cylinder Target with Haptic Feedback (Milku Project) - Kelompok 5

Repository ini berisi source code dan aset untuk Tugas Akhir AR/VR. Project ini mengimplementasikan manipulasi objek silinder virtual pada botol Milku dengan integrasi Haptic Feedback.

## 👥 Anggota Kelompok
1. Muh. Al Faiz - Project Leader & Documentation
2. Vicram L - Lead Dev & DevOps
3. Yuyun Aulia Afrianty - 3D Artist & UI/UX
4. Sifa Sahira - AR Specialist & Presenter
5. Fransisca Aprilia Tarabu - VR Specialist & QA

## 📂 Struktur Repository
- **/src**: Source code Unity Project (Unity 2022.3 LTS).
- **/assets**: Aset mentah (Foto label, tekstur, desain UI).
- **/build**: File aplikasi Android siap pakai (.apk).
- **/docs**: Laporan teknis.
- **/demo**: Video demonstrasi penggunaan aplikasi.

## Fitur Utama
1. **Cylinder Tracking (Non-Vuforia):** Menggunakan ARFoundation Image Tracking yang dikalibrasi untuk permukaan melengkung.
2. **Visual Recoil:** Objek mengecil saat disentuh (simulasi benda lunak).
3. **Haptic Feedback (VR):** Getaran fisik pada HP saat interaksi sentuh.
4. **Auto-Rotation:** Objek berputar otomatis menampilkan seluruh sisi label.

## Cara Build Project (Untuk Developer)
1. Clone repository ini.
2. Buka Unity Hub, pilih "Add Project from Disk" dan arahkan ke folder `/src`.
3. Pastikan modul **Android Build Support** sudah terinstall di Unity.
4. Buka Scene utama di `Assets/Scenes/MainScene`.
5. Pergi ke `File > Build Settings`.
6. Switch Platform ke **Android**.
7. Klik **Build**.

## Cara Menjalankan Aplikasi
1. Download file `.apk` dari folder `/build`.
2. Install di HP Android.
3. Siapkan botol **Milku 200ml** (Rasa Stroberi sesuai label).
4. Buka aplikasi, izinkan akses kamera.
5. Arahkan kamera ke botol hingga objek virtual muncul.
6. **Sentuh layar** pada objek untuk merasakan efek Recoil dan Getaran.

---
**Tugas Mata Kuliah Desain AR/VR**