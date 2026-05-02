using Modul9_103022400073;

class Program()
{

    public static void Main()
    {
        BankTransferConfig BTConfig = new BankTransferConfig();
        BTConfig.SetDefault();
        BTConfig.WriteConfigFile();

        Config config = BTConfig.config;

        if (config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer: ");
        }else if (config.lang == "id")
        {
            Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
        }

        int jumlahTransfer = int.Parse(Console.ReadLine());

        int biayaTransfer = jumlahTransfer <= config.transfer.threshold 
                    ? config.transfer.low_fee : config.transfer.high_fee;

        int totalBiaya = jumlahTransfer + biayaTransfer;

        if (config.lang == "en")
        {
            Console.WriteLine($"Transfer Fee = {biayaTransfer}");
            Console.WriteLine($"Total Amount = {totalBiaya}");
            Console.WriteLine("Select Transfer Method: ");
        }
        else if (config.lang == "id")
        {
            Console.Write($"Biaya Transfer = {biayaTransfer}");
            Console.Write($"Total Biaya = {totalBiaya}");
            Console.WriteLine("Pilih Metode Transfer: ");
        }

        int count = 1;
        for (int i = 0; i < config.methods.Count(); i++)
        {
            Console.WriteLine($"{count}. {config.methods[i]}");
            count++;
        }

        Console.Write("==>");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (config.lang == "en")
        {
            Console.Write($"\nPlease type \"{config.confirmation.en}\" to confirm the transaction: ");
        }
        else if (config.lang == "id")
        {
            Console.Write($"\nKetik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi: ");
        }

        string konfirmasi = Console.ReadLine();

        if (config.lang == "en")
        {
            if (konfirmasi == config.confirmation.en) {
                Console.Write($"The transfer is completed using {config.methods[choice]}");
            }
            else
            {
                Console.Write($"Transfer is cancelled");
            }
        }
        else if (config.lang == "id")
        {
            if (konfirmasi == config.confirmation.id) {
                Console.Write($"Proses transfer berhasli menggunakan {config.methods[choice]}");
            }
            else
            {
                Console.Write($"Transfer dibatalkan");
            }
        }


    }
}




