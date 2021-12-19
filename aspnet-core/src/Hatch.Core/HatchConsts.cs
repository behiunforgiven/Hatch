using Hatch.Debugging;

namespace Hatch
{
    public class HatchConsts
    {
        public const string LocalizationSourceName = "Hatch";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fa37f23e8b224309be04bf6272d69990";
    }
}
