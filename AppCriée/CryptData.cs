using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AppCriée
{
	class CryptData
    {
	    private string _value;
        private string _key = "vVucT9MHuTM8CxYp/owSndrLUwfbNaMiWY59hGY+tg8=";
        private RijndaelManaged _rCrypt;

        public CryptData(object value)
		{
            if(value is byte[])
            {
                _value = UTF8Encoding.UTF8.GetString((byte[]) value);
            }
            if(value is string)
            {
                _value = (string) value;
            }
            byte[] keyArray = Convert.FromBase64String(_key);
            RijndaelManaged rCrypt = new RijndaelManaged();
            rCrypt.KeySize = keyArray.Length * 8; // in bits
            rCrypt.Key = keyArray;
            rCrypt.Mode = CipherMode.ECB; // http://msdn.microsoft.com/en-us/library/system.security.cryptography.ciphermode.aspx
            rCrypt.Padding = PaddingMode.None;  // better lang support
            _rCrypt = rCrypt;
        }

        public String DecryptData()
        {
            if(_value == null || _value == "")
            {
                return null;
            }
            ICryptoTransform cTransform = _rCrypt.CreateDecryptor();
            byte[] datadecode = Convert.FromBase64String(_value);
            byte[] resultArray = cTransform.TransformFinalBlock(datadecode, 0, datadecode.Length);
            ClearBlanckByte(ref resultArray, 16);
            return UTF8Encoding.UTF8.GetString(resultArray).Replace("\0", "");
        }

        public string EncryptData()
        {
            if (_value == null || _value == "")
            {
                return null;
            }
            ICryptoTransform cTransform = _rCrypt.CreateEncryptor();
            byte[] arraydata  = UTF8Encoding.UTF8.GetBytes(_value);
            AddBlanckByte(ref arraydata, 16);
            byte[] resultArray = cTransform.TransformFinalBlock(arraydata, 0, arraydata.Length);
            return Convert.ToBase64String(resultArray);
        }
        public static void AddBlanckByte(ref byte[] src, int pad)
        {
            int lensrc = src.Length;
            int len = (lensrc + pad) / pad * pad;
            Array.Resize(ref src, len);
            for(int i = lensrc; i < len; i++)
            {
                src[i] = (byte) (len - lensrc);
            }
        }
        public static void ClearBlanckByte(ref byte[] src, int pad)
        {
            for(int i=src.Length-1; i>=src.Length-pad; i--)
            {
                if(src.Length-i==src[i])
                {
                    for(int indice=i; indice < src.Length; indice++)
                    {
                        src[indice] = 0;
                    }
                    break;
                }
            }
        }
  }
}
