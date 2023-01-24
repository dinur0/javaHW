string [] text = {"вл",",bk)$","3l","hello","a4$"};
string [] result = text.Where(a => a.Length <= 3).ToArray();
System.Console.WriteLine(string.Join(" ", result));
