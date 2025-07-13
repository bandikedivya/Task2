using System;

interface IMall
{
    void Entry();
    void Exit();
}

class Phenoix : IMall
{
    public void Entry()
    {
        Console.WriteLine("People Enter the Phenoix Mall Via Entry");
    }

    public void Exit()
    {
        Console.WriteLine("People Exit the Phenoix Mall Via Exit");
    }

    
}

class MallProgram
{
    static void Main()
    {
        IMall mall = new Phenoix();
        mall.Entry();
        mall.Exit();
        
    }
}

