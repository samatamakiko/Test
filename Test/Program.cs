// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main()
    {
        var a = 1.0;
        var b = a / 5.0;
        Console.WriteLine(b.ToString());

        //varは型を自動で推測してくれるので小数点ないとint型になる
        //0.2と出したのであれば小数点つける


        var c = 1.0;
        var d = 0.0;
        d = c / 13.0f;
        Console.WriteLine(b * 13);

        //dが定義されてないまま代入している
        // 1の出し方はちょっと分からない・・・

    }
}

