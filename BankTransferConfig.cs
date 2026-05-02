using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul9_103022400073
{
    internal class BankTransferConfig
    {

        public Config config { get; set; }

        private string filepath;

        public BankTransferConfig()
        {
            this.filepath = Path.GetFullPath("bank_transfer_config.json");
        }

        public void ReadConfigFile()
        {
            string json = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(json);
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions() { 
                WriteIndented = true,
            };

            string tulisan = JsonSerializer.Serialize(config, options);

            File.WriteAllText(filepath, tulisan);
        }

        public void SetDefault()
        {
            Confirmation confirmation = new Confirmation("yes","ya");
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            List<string> methods = new List<string>();
            methods.Add("RTO (real-time)");
            methods.Add("SKN");
            methods.Add("RTGS");
            methods.Add("BI FAST");

            config = new Config("en", transfer, methods, confirmation);
            
        }
    }
}
