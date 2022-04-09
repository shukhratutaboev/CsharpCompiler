using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace CsharpCompiler.Pages;
public partial class Problems
{
    public List<Models.Problems> AllProblems { get; set; } = new List<Models.Problems>();
    
    [Inject]
    public HttpClient Http { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var json = await Http.GetStringAsync("https://script.googleusercontent.com/macros/echo?user_content_key=7f8_eqYLtG7QMz-KQUJ4clomN0TxMn_W5Ghkroh1VIDRlm6NtLINqjnTAxUjrr1qdA6UeN0f8DvAeS0no8dSEvVAtAfDQj7xm5_BxDlH2jW0nuo2oDemN9CCS2h10ox_1xSncGQajx_ryfhECjZEnHzFefthpjCOGXALboFFnPdGMIMZhpkxaGnQJ1yQrUSYHokAiQ10-lL46iqjvJZ5Tn2GL57J9v2GEfS-gXUOzcfqZSLif9qO0tz9Jw9Md8uu&lib=MerSE56bODSHPg4_u3Woa6E8G4nBBDVKd");
        Console.WriteLine(json);
        AllProblems = JsonSerializer.Deserialize<List<Models.Problems>>(json);
    }
}