using System.Data;

namespace DataLoader.Parser
{
    public interface IParser
    {
        DataTable Parse(string path);
    }
}