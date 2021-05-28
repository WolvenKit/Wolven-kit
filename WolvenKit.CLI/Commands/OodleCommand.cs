using System.CommandLine;
using System.CommandLine.Invocation;

namespace CP77Tools.Commands
{
    public class OodleCommand : Command
    {
        #region Fields

        private new const string Description = "Some helper functions related to Oodle.";
        private new const string Name = "oodle";

        #endregion Fields

        #region Constructors

        public OodleCommand() : base(Name, Description)
        {
            AddOption(new Option<string>(new[] { "--path", "-p" }, "Input path."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output path."));
            AddOption(new Option<bool>(new[] { "--decompress", "-d" }, "Decompress with oodle kraken."));
            AddOption(new Option<bool>(new[] { "--compress", "-c" }, "Compress with oodle kraken."));

            Handler = CommandHandler.Create<string, string, bool, bool>(Tasks.ConsoleFunctions.OodleTask);
        }

        #endregion Constructors
    }
}
