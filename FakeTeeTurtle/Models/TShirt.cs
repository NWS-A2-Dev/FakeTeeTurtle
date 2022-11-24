using System.Web;

namespace FakeTeeTurtle.Models;

public class TShirt
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public string ImageURL { get; set; } = string.Empty;
    public string Flag { get; set; } = string.Empty;
    public string Price{ get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string GetDecodedName()
    {
        return (HttpUtility.HtmlDecode(Name));
    }
}