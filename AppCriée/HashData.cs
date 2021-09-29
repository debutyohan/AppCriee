using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;

namespace AppCriée
{
    public class HashData
    {
        private HashAlgorithm _algo;
        private String _value;

        public HashData(String value)
        {
            _value = value;
        }

        public HashAlgorithm Algo { get => _algo; set => _algo = value; }
        public string Value { get => _value; set => _value = value; }

        public String HashCalculate()
        {
            HashAlgorithm algo = new SHA256CryptoServiceProvider();
            Byte[] inputBytes = Encoding.UTF8.GetBytes(_value);
            Byte[] hashedBytes = algo.ComputeHash(inputBytes);
            String hashedStr = BitConverter.ToString(hashedBytes).ToLower();
            String finalhashed = hashedStr.Replace("-", "");
            return finalhashed;
        }
        public String HashCalculate(HashAlgorithm AlgoHash)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(_value);
            Byte[] hashedBytes = AlgoHash.ComputeHash(inputBytes);
            String hashedStr = BitConverter.ToString(hashedBytes).ToLower();
            String finalhashed = hashedStr.Replace("-", "");
            return finalhashed;
        }

    }
}
