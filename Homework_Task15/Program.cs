
int inputNumber = int.Parse(Console.ReadLine()??"0");
if(inputNumber>0&&inputNumber<8)
//{
//if(inputNumber<6)
//{
//Console.WriteLine("Это рабочий день!");
//} 
//else
//{
//Console.WriteLine("Это выходной!");
//}
//}
{
Dictionary<int, string> dict = new Dictionary<int, string>
{
    {1, "рабочий день"},
    {2, "рабочий день"},
    {3, "рабочий день"},
    {4, "рабочий день"},
    {5, "рабочий день"},
    {6, "выходной день"},
    {7, "выходной день"},

};

Console.WriteLine(dict[inputNumber]);

}

else 
{
    Console.WriteLine("Это не день недели!");
}
