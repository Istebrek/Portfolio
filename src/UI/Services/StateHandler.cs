using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Shared.Lists;

namespace UI.Services;

public class StateHandler(
    IListHandler listHandler,
    ProtectedLocalStorage localStorage
) : IStateHandler
{
    public Language CurrentLanguage { get; set; }

    public Action? OnChange { get; set; }

    public async Task InitializeAsync()
    {
        var result = await localStorage.GetAsync<Language>("selectedLanguage");
        await SelectLanguage(result.Success ? result.Value : Language.Swedish);
    }
    public async Task SelectLanguage(Language language)
    {
        CurrentLanguage = language;
        await localStorage.SetAsync("selectedLanguage", CurrentLanguage);
        await listHandler.GetAllData(CurrentLanguage);

        OnChange?.Invoke();
    }
}

public interface IStateHandler
{
    Language CurrentLanguage { get; set; }
    Action? OnChange { get; set; }
    Task SelectLanguage(Language language);
    Task InitializeAsync();
}