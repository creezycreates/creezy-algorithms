using LeetCode.Easy.Palindromes;

TestPalindromeValidator();




void TestPalindromeValidator()
{
    PalindromeValidator validator = new PalindromeValidator();

    Console.WriteLine(">> Checking if 'A man, a plan, a canal: Panama' is a palindome...");
    bool valid = validator.IsPalindome("A man, a plan, a canal: Panama");
    Console.WriteLine(">> " + valid + "\n");

    Console.WriteLine(">> Checking if 'A man, a plan, a canal: Panama' is a palindome...");
    valid = validator.IsPalindome("race a car");
    Console.WriteLine(">> " + valid + "\n");

    Console.WriteLine(">> Checking if 'A man, a plan, a canal: Panama' is a palindome...");
    valid = validator.IsPalindome(" ");
    Console.WriteLine(">> " + valid + "\n");
}