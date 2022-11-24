using FakeTeeTurtle.Models;
using Newtonsoft.Json;

namespace FakeTeeTurtle.Services;

public class TShirtRepository
{
    private TShirt[] Content;

    public TShirtRepository()
    {
        string content = File.ReadAllText("api.json");

        Content = JsonConvert.DeserializeObject<TShirt[]>(content)!.Select(i =>
        {
            i.Link = i.Link.Replace("https://www.teeturtle.com/", "/");
            return i;
        }).ToArray();
    }

    public TShirt[] GetPage(int i)
    {
        return (Content.Skip((i - 1) * 16)
            .Take(16)
            .ToArray());
    }

    public TShirt Get(Guid id)
    {
        return (Content.First(i => i.Id == id));
    }
}