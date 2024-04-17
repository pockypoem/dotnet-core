# Data Transfer Object (DTOs)

> a way to represent the resources that we're going to be managing in this API

* DTO is an object that carries data between processes our application
* It's encapsulate data into simple and standardized format that can be easily transmitted across different layers of an application or across different applications

* Data Transfer Objects (DTOs) adalah objek yang digunakan untuk mengirim data antara bagian-bagian aplikasi yang berbeda, terutama antara layer aplikasi dan layer data atau antara aplikasi client dan server. 
* Tujuan utama dari DTOs adalah untuk mengemas data yang diperlukan dalam bentuk yang sesuai untuk transfer melalui jaringan atau antar layer, dan untuk mengurangi jumlah panggilan antarmuka yang diperlukan dalam komunikasi.
* DTOs biasanya hanya berisi field-field data dan tidak memiliki logika bisnis yang kompleks. Mereka sering digunakan dalam arsitektur berbasis layanan (service-based architecture) dan aplikasi web yang menggunakan RESTful API untuk komunikasi antara client dan server.
* DTO bisa disimpan di folder DTOs atau orang lain biasa menamainya dengan contracts.


## Why DTOs file is record?
* Because records are immutable, meaning that once their properties are set usually at the time we create these records, they can't be a changed. And this immutability is a perfect fit for dto (cause they typically carry data from one point to another without the need for modification).

> And records reduce the boilerplate code that is typically associated with class definitions intended for data holding
* penggunaan DTOs membantu mengurangi jumlah kode yang diperlukan untuk mendefinisikan kelas yang digunakan untuk menyimpan data, yang sering kali menjadi lebih kompleks dan membutuhkan lebih banyak boilerplate code jika tidak menggunakan DTOs. 
* Dengan menggunakan DTOs, pengembang dapat lebih fokus pada logika bisnis inti daripada menghabiskan waktu untuk menulis kode repetitif.