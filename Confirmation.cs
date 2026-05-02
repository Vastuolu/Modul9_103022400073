using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Modul9_103022400073
{
    internal class Confirmation
    {
        [JsonPropertyName("en")]
        public string en { get; set; } = "yes";

        [JsonPropertyName("id")]
        public string id { get; set; } = "ya";

        public Confirmation() { }

        public Confirmation(string en, string id) { 
            this.en = en;
            this.id = id;
        }

    }
}
