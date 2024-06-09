System.Console.WriteLine("我們來玩猜數字吧! \n請輸入你猜的數字,範圍1~30,只有三次機會喔!");
int num = 22;
int guess;
int guess_count = 0;
int guess_limit = 3;
bool win = false;

do
{
    System.Console.Write("請輸入你猜的數字：");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    guess_count ++;

    if(guess > num)
    {
        System.Console.WriteLine("再猜小一點");
    }    
     else if(guess < num)
    {
        System.Console.WriteLine("再猜大一點");
    }
    else
    {
        System.Console.WriteLine("哇!恭喜你猜對了!!!");
        win = true;
    }
 }
while(guess != num && guess_count < guess_limit);

if (!win)
{
    System.Console.WriteLine("抱歉你輸了:(");
}