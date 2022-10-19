using System.Diagnostics;

var digimon = "Guilmon";
var local_fullpath = @"c:\temp";

var image_local_fullpath = @$"{local_fullpath}\{digimon}.png";
var image_url = @$"https://digimon-api.com/images/digimon/w/{digimon}.png";

var image_response = await new HttpClient().GetAsync(image_url);
var image_data = await image_response.Content.ReadAsByteArrayAsync();
File.WriteAllBytes(image_local_fullpath, image_data);

Process.Start("explorer.exe", image_local_fullpath);