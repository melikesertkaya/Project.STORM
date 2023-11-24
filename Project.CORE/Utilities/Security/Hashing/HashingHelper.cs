﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHashing(string password,out byte[] passwordHash,out byte [] passwordSalt)
        {
            using (var hmc = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmc.Key;
                passwordHash = hmc.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHashing(string password, byte[] passwordHash,byte[] passwordSalt)
        {
            using (var hmc = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var completedHash = hmc.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < completedHash.Length; i++)
                {
                    if (completedHash[i] == passwordHash[i])
                        return true;
                    
                }

            }
            return false;
        }
    }
}
