﻿using System;
using System.Collections.Generic;
namespace chazi
{
    public class Hanzi
    {
        public char hanzi;
        public Hanzi(char hanzi)
        {
            this.hanzi = hanzi;
        }

        #region traHanziToSimp
        static string transTraHanziToSimp(string sentence)
        {
            return sentence;
        }
        static char transTraHanziToSimp(char hanzi)
        {
            return hanzi;
        }
        #endregion

        #region simpHanziToTra
        static string transSimpToTraHanzi(string sentence)
        {
            return sentence;
        }
        static char transSimpToTraHanzi(char hanzi)
        {
            return hanzi;
        }
        #endregion
    }

    public class MatchHanzi:Hanzi
    {
        public List<string> font;
        public Dictionary<string, char> sentence;
        public MatchHanzi(char hanzi)
            :base(hanzi)
        {
            
        }
    }
}
