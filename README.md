# MoviesRESTFull

## Tentang Project
### Deskripsi
*Adalah RESTFull API yang dibuat untuk memenuhi syarat Reqruitment di PT Xsis Mitra Utama*

### Framework, Library dan Database
*MoviesRESTFull dibangun dengan ASP.NET Core Web API dengan Framework .NET 6.0 dan MySQL*

Beberapa library yang digunakan, diantaranya :
* Microsoft.AspNet.WebApi.Core
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.Tools
* MySql.EntityFrameworkCore
* Swashbuckle.AspNetCore

Versi Database : MySQL versi 5.7.36

*Table* : **Movie**

| Columns     | Type        | Length | Primary |
| ----------- | ----------- | ------ | ------- |
| id          | int         | 11     | YES     |
| title       | varchar     | 50     |         |
| description | varchar     | 1000   |         |
| rating      | float       |        |         |
| image       | varchar     | 50     |         |
| created_at  | datetime    |        |         |
| updated_at  | datetime    |        |         |

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
* Aplikasi akan otomatis membuka Swagger editor
* Anda juga bisa menggunakan aplikasi pihak ketiga seperti Postman

# Contoh Penggunaan
![index movie](https://drive.google.com/file/d/1sU3FFApTOTfWIMqKEuxZZ2glq0LDJ85F/view?usp=drive_link)
## Get
`api/Movie/GetMovies`
![get movie](https://drive.google.com/file/d/1-hHf6yx47OoccWX4Zyk2dikSge-el-EA/view?usp=drive_link)

## Get by ID
`api/Movie/GetMovieById`
![get movie by id](https://drive.google.com/file/d/1gqZwzhDIDnu8oKWQTUBxepp3tvs7ujBs/view?usp=drive_link)

## Post
`api/Movie/InsertMovie`
![post movie](https://drive.google.com/file/d/18nfVCiVwa6mVdAw74b00wEh42AdXJE43/view?usp=drive_link)

## Put
`api/Movie/UpdateMovie`
![put movie](https://drive.google.com/file/d/1UGDhbLouGldbi040uLWOymfWeItcNN5I/view?usp=drive_link)

## Delete
`api/Movie/DeleteMovie/{Id}`
![delete movie](https://drive.google.com/file/d/1JMKHgHx_0JXfqoyAjBz32-5TQ-UEBd8M/view?usp=drive_link)

# Cara Berkontribusi
Untuk bisa berkontribusi dalam mengembangkan aplikasi ini, silahkan kontak developer terlebih dahulu.

# Lisensi
Lisensi yang digunakan GNU GENERAL PUBLIC LICENSE Version 3
Anda bisa melihatnya pada file `LICENSE.txt`

# Kontak
- Phone : +62 896 3696 7361
- Email : yanbaktra@gmail.com