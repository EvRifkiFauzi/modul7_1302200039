// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Minggu7
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello");

        }
    }

    class readANDwrite
    {
        public BankTransferConfig conf;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public string fileconfig = "bank_transfer_config.json";
        public readANDwrite() 
        {

        }
        private BankTransferConfig ReadConfigFile()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string pathAndFile = path + "/bank_transfer_config.json";
            string json = File.ReadAllText(pathAndFile);

            Program objHasilDeserialisasi = JsonSerializer.Deserialize<Program>(json);

            return objHasilDeserialisasi;
        }
        private void WriteConfig()
        {

        }
        private void setDefault()
        {

        }
    }

    class BankTransferConfig
    {
        public string lang { get; set; }

        public tf transfer { get; set; }
        public string methods { get; set; }
        public confirm confirmation { get; set; }
        public BankTransferConfig() { }
        public BankTransferConfig(string lang, tf transfer, string methods, confirm confirmation) 
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }

    }
    class tf
    {
        public string threshold { get; set; }
        public string low_fee { get; set; }
        public string high_fee { get; set; }
        public tf() { }
        public tf(string threshold, string low_fee, string high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
       
    }
    class confirm
    {
        public string en { get; set; }
        public string id { get; set; }
        public confirm() { }
        public confirm(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
