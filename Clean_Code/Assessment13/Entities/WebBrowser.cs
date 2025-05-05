using Assessment13.Enums;

namespace Assessment13.Entities;

public class WebBrowser
{
    public BrowserName Name { get; set; }
    public int MajorVersion { get; set; }

    public WebBrowser(string name, int majorVersion)
    {
        Name = TranslateStringToBrowserName(name);
        MajorVersion = majorVersion;
    }

    private BrowserName TranslateStringToBrowserName(string name)
    {
        name = name.ToLower();

        if (name.Contains("ie")) return BrowserName.InternetExplorer;
        if (name.Contains("firefox")) return BrowserName.Firefox;
        if (name.Contains("chrome")) return BrowserName.Chrome;
        if (name.Contains("opera")) return BrowserName.Opera;
        if (name.Contains("safari")) return BrowserName.Safari;
        if (name.Contains("dolphin")) return BrowserName.Dolphin;
        if (name.Contains("konqueror")) return BrowserName.Konqueror;
        if (name.Contains("lynx") || name.Contains("linx")) return BrowserName.Linx;

        return BrowserName.Unknown;
    }
}
