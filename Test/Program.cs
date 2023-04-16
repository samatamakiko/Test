// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.FileIO;
using System;


//型変換やり方４種類ある
//1,キャスト　変数の前に（変換したい型）を書く

class CS10
{
    public static void Main(string[] args)
    {
        double d1 = 1.9d;
        int aaa = (int)d1;
        Console.WriteLine(aaa);

        //2, パースのやり方 文字を数値にしたいとき使う
        string value = "10";
        int intValue = int.Parse(value);
        Console.WriteLine(intValue);

        //3,トライパースのやり方
        string bbb = "10";
        int result; //outの後に出力される変数を入れてね、という意味。事前に宣言する必要あり。
        Console.WriteLine( int.TryParse(bbb, out result));
        Console.WriteLine(result);
        //トライパースはboolで返すのが基本なのか・・・？

        //4,コンバート
        string ccc = "10";
        int cccValue = Convert.ToInt32(ccc);
    }
}