using SeminarParticipants.MVC.Services.Base;
using System.Net.Http;

namespace SeminarParticipants.MVC.Services.Base;

public partial class Client : IClient
{
    public HttpClient HttpClient
    {
        get
        {
            return _httpClient;
        }
    }
}