using System;
using System.Collections.Generic;

public class TextInput 
{
    private List<char> _input = new List<char>();

    // write method that adds the given character to the current value of the TextInput object
    public virtual void Add(char c) 
    {
        _input.Add(c);
    }

    // write method that returns the current value of the TextInput object
    public string GetValue()
    {
        return string.Join("", _input);
    }
}

public class NumericInput : TextInput
{
    private List<char> _input = new List<char>();
    public override void Add(char c)
    {
        Console.WriteLine(c);
        if (c >= '0' && c <= '9')
        {
            _input.Add(c);
        }
    }
    public new string GetValue()
    {
        return string.Join("", this._input);
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        //TextInput input = new TextInput();
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');

        Console.WriteLine("testing");

        Console.WriteLine(input.GetValue());
    }
}