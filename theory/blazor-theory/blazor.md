# Blazor
![Blazor docs](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)

## What is Blazor?
> Blazor is a modern web framework for building interactive Web UIs using HTML, CSS, and C#

![Image](./images/04-definition-blazor-gpt.png) 

## A component based Web UI framework
![Image](./images/02-component-based.png)

## A single page application (like) framework
![Image](./images/03-spa.png)

## Create Blazor Project
* `cd GameStore`
* Terminal: `dotnet new blazor --help`: to see many different options in template
* Terminal: `dotnet new blazor --interactivity None --empty -n GameStore.Frontend`


* `app.UseHsts();` and `app.UseHttpsRedirection();` to make sure that your application can only work with https and not with standard http.
* `app.UseStaticFiles();` adalah metode yang digunakan dalam ASP.NET Core untuk menambahkan middleware yang memungkinkan server web untuk menyajikan file statis seperti gambar, file CSS, file JavaScript, dan file lainnya kepada pengguna.
* `app.MapRazorComponents<App>();` adalah metode yang digunakan dalam Blazor untuk menambahkan routing untuk komponen Razor yang didefinisikan dalam aplikasi.


## Razor Component Life Cycle
![Image](/images/08-bout-razor-component-lifecycle.png)


## Fyi about Blazor
Blazor mengkompilasi kode C# Anda menjadi WebAssembly saat aplikasi dimuat di browser. Hal ini memungkinkan Anda menulis kode C# yang menjalankan logika aplikasi Anda langsung di browser tanpa memerlukan JavaScript.

Blazor juga memiliki kemampuan untuk berinteraksi dengan DOM (Document Object Model) menggunakan fitur-fitur seperti "Razor Components" yang dapat mengubah tampilan berdasarkan perubahan data dan peristiwa yang terjadi di aplikasi Anda. Meskipun demikian, Blazor tetap menggunakan JavaScript di bawah layar untuk beberapa fungsi tertentu yang tidak didukung oleh WebAssembly, seperti pengaturan waktu, animasi, dan interaksi dengan API browser tertentu.

### Seputar Web Assembly
* [Dokumentasi Web Assembly](https://webassembly.org/)
* ![Image](./images/05-webassembly.png)



## Asynchronous Programming in ASP.NET Core
![Image](/images/15-asynchronous.png) <br>

