using System;
using System.IO;
using System.Net;

WebClient webClient = new WebClient();

try {
webClient.DownloadFile("https://danepubliczne.imgw.pl/api/data/synop/format/html", @"C:\Users\USER\Desktop\dane.txt"); // Pobierzemy wszystkie dane z tej strony i przekażemy je do pliku dane.txt
} catch (WebException) {
Console.WriteLine("Niestety wystąpił wyjątek przy pobieraniu pliku!");
// Nasz program powiadomi użytkownika o niepowodzeniu pobierania pliku.
}
