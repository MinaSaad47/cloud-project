namespace Games.Mvc.Settings;

public class OpenIdSettings
{
    public string Authority { get; set; } = string.Empty;
    public string ClientId { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;
    public string CallbackPath { get; set; } = string.Empty;
    public string RedirectUri { get; set; } = string.Empty;
}