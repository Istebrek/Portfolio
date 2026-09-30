using System.Globalization;
using System.Resources;
using Shared.Lists;
using UI.Services;

namespace UI.Resources;

public class SharedText
{
    
}

public class SharedTextService(IStateHandler stateHandler)
{
    private readonly ResourceManager _manager =
        new ResourceManager("UI.Resources.SharedText", typeof(SharedText).Assembly);

    public string Get(string key)
    {
        var culture = stateHandler.CurrentLanguage == Language.Swedish
            ? new CultureInfo("sv")
            : new CultureInfo("en");
        return _manager.GetString(key,culture) ?? key;
    }
}