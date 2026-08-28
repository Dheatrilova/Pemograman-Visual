## 👨‍💻 Praktikan

**Nama:** *Dhea Tri Lova Simanjuntak*
**NIM:** *241712017*
**Kom:** A1
**Praktikum:** Pemograman Visual

### 1. Pengenalan GUI
**Graphical User Interface (GUI)** adalah antarmuka yang memungkinkan pengguna berinteraksi dengan aplikasi melalui elemen visual seperti tombol, teks, input, dan jendela. GUI membuat aplikasi lebih mudah digunakan karena pengguna tidak harus selalu berinteraksi melalui terminal atau command line.

Contoh komponen GUI yang digunakan:
- 🪟 **Form**
- 🏷️ **Label**
- ⌨️ **TextBox**
- 🔘 **Button**

## 🧩 Komponen Dasar
### 🪟 Form

**Form** merupakan jendela utama tempat komponen-komponen GUI ditempatkan.Form dapat digunakan sebagai wadah untuk:
- Label
- TextBox
- Button
- Komponen GUI lainnya

Contoh:
```text
+--------------------------------------+
|          Aplikasi Sederhana          |
|                                      |
| Nama : [____________________]        |
|                                      |
|             [ SUBMIT ]               |
+--------------------------------------+

### 🏷️ Label
**Label** digunakan untuk menampilkan teks atau informasi kepada pengguna.
Contoh penggunaan:
```text
Nama:
NIM:
Alamat:
```
Label biasanya digunakan sebagai keterangan untuk TextBox atau komponen lainnya.


### ⌨️ TextBox
**TextBox** digunakan untuk menerima input dari pengguna.

Contoh:

```text
Nama : [ eyaa                ]
NIM  : [ 241712017           ]
```
TextBox dapat digunakan untuk menerima berbagai jenis data seperti:
* Nama
* NIM
* Alamat
* Nilai
* Username
* dan data lainnya

---

### 🔘 Button
**Button** merupakan komponen yang digunakan untuk menjalankan suatu aksi ketika pengguna menekannya.
Contoh:
```text
[ SIMPAN ]
[ RESET ]
[ KELUAR ]
```
Button dapat diberikan aksi melalui **Event**, salah satunya adalah:
```text
Click Event
```

# ⚙️ Properti Komponen
Setiap komponen GUI memiliki berbagai **Property** yang dapat digunakan untuk mengatur tampilan maupun perilakunya.
Beberapa properti dasar yang umum digunakan:
| Property    | Fungsi                                     |
| ----------- | ------------------------------------------ |
| `Name`      | Menentukan nama komponen                   |
| `Text`      | Menentukan teks yang ditampilkan           |
| `Font`      | Mengatur jenis dan ukuran font             |
| `ForeColor` | Mengatur warna teks                        |
| `BackColor` | Mengatur warna latar                       |
| `Size`      | Mengatur ukuran komponen                   |
| `Location`  | Mengatur posisi komponen                   |
| `Visible`   | Mengatur apakah komponen ditampilkan       |
| `Enabled`   | Menentukan apakah komponen dapat digunakan |

### Contoh
Button dengan:
```text
Name = btnSimpan
Text = Simpan
```
Sedangkan TextBox:
```text
Name = txtNama
```

Penamaan komponen yang jelas akan membuat kode lebih mudah dibaca dan dikelola.
---
# 🖱️ Event pada Button
**Event** adalah kejadian yang terjadi ketika pengguna melakukan suatu tindakan terhadap komponen.
Contoh event yang umum:
* `Click`
* `MouseEnter`
* `MouseLeave`
* `KeyPress`
* `TextChanged`
Pada pertemuan ini, fokus utama adalah **Click Event** pada Button.
Contoh sederhana:
```csharp
private void btnSimpan_Click(object sender, EventArgs e)
{
    MessageBox.Show("Data berhasil disimpan!");
}
```
Ketika Button `btnSimpan` diklik, program akan menampilkan pesan:
```text
Data berhasil disimpan!
```

---

# 🔄 Interaksi Antar-Komponen
Komponen GUI dapat saling berinteraksi.
Contohnya, data dari TextBox dapat diambil ketika Button ditekan.
```csharp
private void btnTampil_Click(object sender, EventArgs e)
{
    string nama = txtNama.Text;
    MessageBox.Show("Halo, " + nama);
}
```
Jika pengguna memasukkan:

```text
Nama : Eya
```
Kemudian menekan Button, maka program akan menampilkan:
```text
Halo, Eya
```

---
# 🛠️ Praktik
Pada sesi praktik, mahasiswa akan membuat sebuah aplikasi GUI sederhana yang terdiri dari:
### Komponen
* 1 buah **Form**
* 2 buah **Label**
* 1 buah **TextBox**
* 1 buah **Button**

### Contoh Tampilan
```text
+--------------------------------+
|       DATA MAHASISWA           |
|                                |
| Nama : [________________]      |
|                                |
|          [ TAMPILKAN ]         |
+--------------------------------+
```

### Alur Program
```text
User memasukkan nama
        ↓
User menekan Button
        ↓
Program mengambil data dari TextBox
        ↓
Program menampilkan pesan
```

### Contoh Program
```csharp
private void btnTampilkan_Click(object sender, EventArgs e)
{
    string nama = txtNama.Text;

    MessageBox.Show("Nama Anda adalah " + nama);
}
```

---
# 📝 Tugas Praktikum
Buatlah sebuah aplikasi GUI sederhana dengan tema:
## 🎓 Form Data Mahasiswa
Aplikasi harus memiliki komponen berikut:
| Komponen | Jumlah    | Fungsi                      |
| -------- | --------- | --------------------------- |
| Form     | 1         | Sebagai tampilan utama      |
| Label    | Minimal 3 | Memberikan keterangan input |
| TextBox  | Minimal 3 | Menerima data mahasiswa     |
| Button   | Minimal 2 | Menjalankan aksi            |

### Data yang harus diinput:
* Nama
* NIM
* Program Studi

### Button yang digunakan:
**1. Tampilkan**
Ketika ditekan, program menampilkan data mahasiswa yang telah dimasukkan.
Contoh:
```text
Data Mahasiswa
Nama : Eya
NIM  : 231234567
Prodi: Teknik Informatika
```

**2. Reset**
Ketika ditekan, seluruh TextBox dikosongkan.
Contoh:
```csharp
txtNama.Clear();
txtNim.Clear();
txtProdi.Clear();
```

# 🎯 Tujuan Pembelajaran
Setelah menyelesaikan praktikum ini, mahasiswa diharapkan mampu:
* Memahami konsep dasar GUI.
* Menjelaskan fungsi dan peran **Form, Label, TextBox, dan Button**.
* Mengetahui properti dasar dari setiap komponen.
* Menambahkan komponen ke dalam Form.
* Mengatur properti komponen melalui Designer.
* Memahami konsep dasar Event.
* Membuat interaksi sederhana menggunakan **Click Event**.
* Mengambil data dari TextBox dan menampilkannya melalui program.

---

# 📂 Struktur Repository
Struktur repository dapat dibuat seperti berikut:
```text
Pertemuan-02-GUI/
│
├── README.md
│
├── Materi/
│   └── Pertemuan-02-GUI.pdf
│
├── Praktik/
│   └── GUI-Sederhana/
│       └── ...
│
└── Tugas/
    └── Form-Data-Mahasiswa/
        └── ...
```

# 💻 Teknologi yang Digunakan
* **Programming Language:** C#
* **GUI Framework:** Windows Forms
* **IDE:** Visual Studio
* **Platform:** Windows
