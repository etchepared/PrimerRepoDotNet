using System.Runtime.InteropServices.ObjectiveC;

namespace PrimerRepoDotNet.Infrastructure
{
    public class ApiSuccessResponse
    {
        public int Status { get; set; }
        public object? Data { get; set; }
    }
}
