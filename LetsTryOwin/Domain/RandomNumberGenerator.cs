using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsTryOwin.Domain
{
    public interface IRandomNumberGenerator
    {
        int GetRandomNumber();
    }

    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int GetRandomNumber()
        {
            return new Random().Next();
        }
    }
}