public static class MysteryStack1
{

    //Este codigo devuelve al reves una palabra:

    /*
    text= 'carro'

    result = 'orrac'
    
    */
    public static string Run(string text)
    {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}