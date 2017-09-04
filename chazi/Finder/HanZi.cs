using System;
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
    }

    public class MatchHanzi:Hanzi
    {
        public  string font;
        public 
        public MatchHanzi(char hanzi)
            :base(hanzi)
        {
            
        }
    }
}
