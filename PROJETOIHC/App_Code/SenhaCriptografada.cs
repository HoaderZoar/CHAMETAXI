using System;
using System.Collections.Generic;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for SenhaCriptografada
/// </summary>
public class SenhaCriptografada
{
    private string senha;
    public override string ToString(){
        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        Byte[] hashedBytes;
        UTF8Encoding encoder = new UTF8Encoding();
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(senha));
        StringBuilder encryptedValueBuilder= new StringBuilder();
        for (int i=0; i< hashedBytes.Length; i++){
            encryptedValueBuilder.Append(hashedBytes[i].ToString("x2"));
        }
        string senha_Criptografada = encryptedValueBuilder.ToString();
        return senha_Criptografada;
    }

    public SenhaCriptografada(string senha)
    {
        this.senha= senha;
    }
}
