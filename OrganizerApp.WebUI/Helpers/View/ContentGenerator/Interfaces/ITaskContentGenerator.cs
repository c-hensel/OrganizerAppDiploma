using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerApp.WebUI.Helpers.View.ContentGenerator.Interfaces
{
    public interface ITaskContentGenerator : IContentGenerator
    {
        string GetContextHtmlSelectedState(string context, string expectedContextValue);
        string GetProjectHtmlValue(int? projectID);
        string GetProjectName(int? projectID, string name);
    }
}
