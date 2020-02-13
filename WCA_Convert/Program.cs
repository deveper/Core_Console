using System;

namespace WCA_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //// byte, sbyte, short, ushort, int, uint, long, ulong
            //byte s1 = Convert.ToByte(cevrilecek);
            //sbyte s2 = Convert.ToSByte(cevrilecek);
            //short s3 = Convert.ToInt16(cevrilecek);
            //ushort s4 = Convert.ToUInt16(cevrilecek);
            //int s5 = Convert.ToInt32(cevrilecek);
            //uint s6 = Convert.ToUInt32(cevrilecek);
            //long s7 = Convert.ToInt64(cevrilecek);
            //ulong s8 = Convert.ToUInt64(cevrilecek);


            //// float, double, decimal

            //float s9 = Convert.ToSingle(cevrilecek);
            //double s10 = Convert.ToDouble(cevrilecek);
            //decimal s11 = Convert.ToDecimal(cevrilecek);


            //// string, char,
            //string gelenSayi1 = Convert.ToString(s10);
            //string gelenSayi2 = s10.ToString();


            // bool
            string s = "true";
            bool result = Convert.ToBoolean(s);//true:)
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
