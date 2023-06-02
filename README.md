# MoviesRESTFull

## Tentang Project
### Deskripsi
*Adalah RESTFull API yang dibuat untuk memenuhi tes di PT Xsis Mitra Utama*

### Framework, Library dan Database
*MoviesRESTFull dibangun dengan ASP.NET Core Web API dengan Framework .NET 6.0 dan MySQL*

Beberapa library yang digunakan, diantaranya :
* Microsoft.AspNet.WebApi.Core
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.Tools
* MySql.EntityFrameworkCore
* Swashbuckle.AspNetCore

Versi Database : MySQL versi 5.7.36

# Getting Started
## Requirement/Kebutuhan
Untuk Requierement/Kebutuhan dalam menjalankan REST API ini, diantaranya :
* Visual Studio 2022.
* Web Server seperti XAMPP, WAMPP dan sebagainya.
* SQL Editor seperti PhpMyAdmin, HeidiSQL dan sebagainya.

## Cara Install
Untuk dapat menggunakan RESTFull API ini adalah sebagai berikut :
* Buka Visual Studio anda
* Dapatkan source dengan meng-clone pada link berikut https://github.com/yb6241/MoviesRESTFull.git
* Buka SQL editor anda
* kemudian restore database db_xsis.sql dengan menggunakan nama yang sama `db_xsis`
* Untuk merubah koneksi database dapat dikonfigurasi pada file `appsettings.json`
```json
"ConnectionStrings": {
    "DefaultConnection": "server=127.0.0.1;port=3306;user=root;password=;database=db_xsis;"
  }
```
* Jalankan aplikasi dengan menekan `F5`

# Contoh Penggunaan
## Get

## Get by ID

## Post

## Put

## Delete

# Cara Berkontribusi
Untuk bisa berkontribusi dalam mengembangkan aplikasi ini, silahkan kontak developer terlebih dahulu.

# Lisensi
Lisensi yang digunakan GNU GENERAL PUBLIC LICENSE Version 3
Anda bisa melihatnya pada file `LICENSE.txt`

# Kontak
+62 896 3696 7361
yanbaktra@gmail.com