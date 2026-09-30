using Microsoft.AspNetCore.Components;
using Shared.Models;
using UI.Services;

namespace UI.Components.Minis.Reusables;

public partial class Summary : ComponentBase
{
    [Inject]
    private IStateHandler? StateHandler { get; set; }

    [Inject]
    private IObjectStore? ObjectStore { get; set; }

    [Parameter] public required string SummaryPart { get; set; }
    [Parameter] public List<object?> Objects { get; set; } = [];

    private List<ProjectSummaryDto> projectSummaries { get; set; } = [];

    protected override void OnInitialized()
    {
        StateHandler!.OnChange += StateHasChanged;
        ObjectStore!.OnChange += SetLists;
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            SetLists();
        }
    }

    public void SetLists()
    {
        projectSummaries = ObjectStore!.CurrentProjectSummaries ?? [];
        StateHasChanged();
    }

    public void Dispose()
    {
        StateHandler!.OnChange -= StateHasChanged;
        ObjectStore!.OnChange -= StateHasChanged;
    }
}