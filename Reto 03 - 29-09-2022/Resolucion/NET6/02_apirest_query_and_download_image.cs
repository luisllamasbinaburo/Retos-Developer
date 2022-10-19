using System;
using System.Diagnostics;
using System.Text.Json.Nodes;

var search_term = "death";
var local_fullpath = @"c:\temp";

var url_search = $"https://www.digi-api.com/api/v1/digimon?name={search_term}";
var response_search = new HttpClient().GetAsync(url_search).Result;
var json_search = await response_search.Content.ReadAsStringAsync();
var candidates = JsonNode.Parse(json_search)["content"].AsArray();

foreach (var digimon in candidates)
{
    var name_digimon = digimon["name"].ToString();
    var image_local_fullpath = @$"{local_fullpath}\{name_digimon}.png";

    var url_digimon = digimon["href"].ToString();
    var response = new HttpClient().GetAsync(url_digimon).Result;
    var json = await response.Content.ReadAsStringAsync();

    var images = JsonNode.Parse(json)["images"].AsArray();
    var image_url = images.First()["href"].ToString();

    var image_response = await new HttpClient().GetAsync(image_url);
    var image_data = await image_response.Content.ReadAsByteArrayAsync();
    File.WriteAllBytes(image_local_fullpath, image_data);

    Process.Start("explorer.exe", image_local_fullpath);
}