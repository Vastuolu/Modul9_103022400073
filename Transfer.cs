using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Modul9_103022400073
{
    internal class Transfer
    {
        [JsonPropertyName("threshold")]
        public int threshold { get; set; } = 25000000;

        [JsonPropertyName("low_fee")]
        public int low_fee { get; set; } = 6500;

        [JsonPropertyName("high_fee")]
        public int high_fee { get; set; } = 15000;

        public Transfer() { }
        
        public Transfer(int threshold, int low_fee, int high_fee) {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
}
