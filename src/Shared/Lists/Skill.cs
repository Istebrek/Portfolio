using System.ComponentModel;

namespace Shared.Lists;

public enum Skill
{
    [Description(".NET")]
    DotNet = 1,

    [Description("C#")]
    CSharp,

    [Description("Blazor")]
    Blazor,

    [Description("ASP.NET Core")]
    AspNetCore,

    [Description("Azure")]
    Azure,

    [Description("SQL Server")]
    SqlServer,

    [Description("Azure SQL")]
    AzureSql,

    [Description("CosmosDB")]
    CosmosDb,

    [Description("MySQL")]
    MySql,

    [Description("SQLite")]
    SQLite,

    [Description("Azure DevOps")]
    AzureDevOps,

    [Description("Git")]
    Git,

    [Description("GitHub")]
    GitHub,

    [Description("GitHub Actions")]
    GitHubActions,

    [Description("Docker")]
    Docker,

    [Description("Docker Hub")]
    DockerHub,

    [Description("Docker Compose")]
    DockerCompose,

    [Description("Terraform")]
    Terraform,

    [Description("Bicep")]
    Bicep,

    [Description("MongoDB")]
    MongoDB,

    [Description("MongoDB Atlas")]
    MongoDbAtlas,

    [Description("YAML")]
    YAML,

    [Description("XUnit")]
    XUnit,

    [Description("Smoke Tests")]
    Smoke,

    [Description("API")]
    API,

    [Description("REST")]
    REST,

    [Description("GraphQL")]
    GraphQL,

    [Description("Playwright")]
    Playwright,

    [Description("JSON")]
    JSON,

    [Description("XML")]
    XML,

    [Description("CSS")]
    CSS,

    [Description("HTML")]
    HTML,

    [Description("Mermaid")]
    Mermaid,

    [Description("Markdown")]
    Markdown,

    [Description("JavaScript")]
    JavaScript,

    [Description("Express.js")]
    Express,

    [Description("Node.js")]
    Node,

    [Description("React")]
    React,

    [Description("Next.js")]
    Next,

    [Description("EntraID")]
    EntraId,

    [Description("Azure Container Apps")]
    AzureContainerApps,

    [Description("Azure Managed Environments")]
    AzureManagedEnvironments,

    [Description("Azure Container Registry")]
    AzureContainerRegistry,

    [Description("Azure Web Apps")]
    AzureWebApps,

    [Description("Azure API Management")]
    AzureApiManagement,

    [Description("Azure Log Analytics")]
    AzureLogAnalytics,

    [Description("Azure Functions")]
    AzureFunctions,

    [Description("Azure Logic Apps")]
    AzureLogicApps,

    [Description("Azure IAM")]
    AzureIAM,

    [Description("Azure RBAC")]
    AzureRBAC,

    [Description("Azure Key Vault")]
    AzureKeyVault,

    [Description("Azure Key Vault Secrets")]
    AzureKeyVaultSecrets,

    [Description("Virtual Network")]
    VirtualNetwork,

    [Description("Azure User Assigned Managed Identity")]
    AzureUami,

    [Description("Continuous Integration/Continuous Deployment")]
    CICD,

    [Description("Bash")]
    Bash,

    [Description("WSL")]
    WSL,

    [Description("PowerShell")]
    PowerShell,

    [Description("Software Bill of Materials")]
    SBOM,

    [Description("Agile Development")]
    Agile,

    [Description("SCRUM")]
    SCRUM,

    [Description("JWT")]
    JWT,

    [Description("EasyAuth")]
    EasyAuth,

    [Description("OAuth2")]
    OAuth2,

    [Description("OIDC")]
    OIDC,

    [Description("Microsoft Word")]
    MicrosoftWord,

    [Description("Microsoft Excel")]
    MicrosoftExcel,

    [Description("Microsoft PowerPoint")]
    MicrosoftPowerPoint,

    [Description("Microsoft Teams")]
    MicrosoftTeams,

    [Description("Zoom")]
    Zoom,

    [Description("Visual Studio")]
    VisualStudio,

    [Description("Visual Studio Code")]
    VisualStudioCode,

    [Description("VPS")]
    VPS,

    [Description("Caddy")]
    Caddy,

    [Description("Domain")]
    Domain,

    [Description("DNS")]
    DNS,

    [Description("IP")]
    IP
}
