using extention;

string input = "Salam zulu. Necəsən zulu,";
string pattern = "zulu";
int count = input.MatchCount(pattern);
Console.WriteLine(count);