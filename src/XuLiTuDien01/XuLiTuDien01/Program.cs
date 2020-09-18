using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLiTuDien01
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"C:\git\TuDienTiengViet\ResultXuLiTuDien\vv30K.index";
            var resultFileName = @"C:\git\TuDienTiengViet\ResultXuLiTuDien\TuDienXuLi01.txt";
            string[] filelines = File.ReadAllLines(filename);
            List<string> fileRes = new List<string>();
            foreach (var item in filelines)
            {
                var idx = item.IndexOf("\t");
                var strConCat = item.Substring(0, idx);
                //Console.WriteLine(strConCat);
                if (strConCat.Contains(" "))
                {
                    //Console.WriteLine(strConCat);
                    fileRes.Add(strConCat);
                }
            }
            File.WriteAllLines(resultFileName, fileRes);
        }
    }
}
