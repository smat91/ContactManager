using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContactManager
{
    public partial class Login : Form
    {
        int loginTrys = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // User = Admin !!! NUR ZU DEBUG ZWECKEN HIER KOMMENTAR VOR ROLLOUT LÖSCHEN !!!
            string user = "c1c224b03cd9bc7b6a86d77f5dace40191766c485cd55dc48caf9ac873335d6f";

            // PW = Admin2021Q3 !!! NUR ZU DEBUG ZWECKEN HIER KOMMENTAR VOR ROLLOUT LÖSCHEN !!!
            string password = "4b84cf5edf20d6dbf0d25b37f4d4eae2f7faaf2fdf4fe4e6b4dd9f9b3df2be0c";

            using (SHA256 sha256Hash = SHA256.Create())
            {
                if (VerifyHash(sha256Hash, TxtUser.Text, user) && VerifyHash(sha256Hash, TxtPassword.Text, password))
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    ++loginTrys;

                    string message = $"Password or username is invalid. Try {loginTrys} of 3.";
                    string caption = "Error detected in input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult  result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.OK && loginTrys >= 3) {
                        Application.Exit();
                    }
                }
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }

        private void LblExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    CmdLogin_Click(sender, e);
                }
        }

        private void Login_Load(object sender, EventArgs e)
        {
          // Login Form zentriet einrichten
          int breite = Screen.PrimaryScreen.Bounds.Width;
          int höhe = Screen.PrimaryScreen.Bounds.Height;

          int x = breite - this.Width;
          int y = höhe - this.Height;

          this.Location = new Point(x / 2, y / 2); 
        }
    }
}
