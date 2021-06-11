using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Services
{
    public interface IInteractionService
    {
        public List<string> BrowseFiles(string filters = "*", string title = "Select files",
            bool multiselect = true);

    }
}
