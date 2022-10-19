using System.Diagnostics;
using System.Text.Json.Nodes;

var digimon = "Guilmon";
var local_fullpath = @"c:\temp";

var image_local_fullpath = @$"{local_fullpath}\{digimon}.png";
var api_url = $"https://www.digi-api.com/api/v1/digimon/{digimon}";

var api_response = new HttpClient().GetAsync(api_url).Result;
var api_json = await api_response.Content.ReadAsStringAsync();

var images = JsonNode.Parse(api_json)["images"].AsArray();
var image_url = images.First()["href"].ToString();

var image_response = await new HttpClient().GetAsync(image_url);
var image_data = await image_response.Content.ReadAsByteArrayAsync();
File.WriteAllBytes(image_local_fullpath, image_data);

Process.Start("explorer.exe", image_local_fullpath);