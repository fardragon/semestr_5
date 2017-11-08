﻿using System.Security.Cryptography;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CarDealership
{
    public enum Screens
    {
        LoginScreen,
        AdminScreen,
        SellerScreen,
        ManagerScreen,
        MechanicScreen,
        Exit
    }

    static class Utility
    {
        public static string CalculateMD5Hash(string data)
        {
            var hash = MD5.Create();
            var passBytes = System.Text.Encoding.ASCII.GetBytes(data);
            var hashBytes = hash.ComputeHash(passBytes);
            var hexString = new SoapHexBinary(hashBytes);
            return hexString.ToString();
        }

    }


}