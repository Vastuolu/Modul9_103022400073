using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;
using System.Text.Json.Serialization;

namespace Modul9_103022400073
{
    internal class Config
    {
        [JsonPropertyName("lang")]
        public string lang { get; set; }

        [JsonPropertyName("transfer")]
        public Transfer transfer { get; set; }

        [JsonPropertyName("methods")]
        public List<string> methods { get; set; }

        [JsonPropertyName("confirmation")]
        public Confirmation confirmation { get; set; }

        public Config() { }

        public Config(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}
