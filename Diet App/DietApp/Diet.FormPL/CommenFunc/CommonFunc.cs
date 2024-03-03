using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Diet.FormPL.CommenFunc
{
    public class CommonFunc
    {
        internal string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string
                    .Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        internal bool WhiteSpaceOrNull(object obj, string fieldName)
        {
            string obj2 = (string)obj;
            if (string.IsNullOrWhiteSpace(obj2))
            {
                MessageBox.Show($"The {fieldName} cannot be left empty.");
                return false;
            }
            return true;
        }
        internal bool ValidationEmail(string email)
        {
            if (email.Contains("@gmail.com") || email.Contains("@hotmail.com"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid email address!");
                return false;
            }
        }
        internal bool ValidationPassword(string password)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Sifreniz en az 7 karakterli olmalidir");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("En az bir karakter buyuk olmalidir.");
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("En az bir kucuk harf bulunmalidir");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("En az bir rakam bulunmalidir.");
                return false;
            }
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("En az bir adet ozel karakter bulunmalidir");
                return false;
            }
            return true;
        }

    }
}
