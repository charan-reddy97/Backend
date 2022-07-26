using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface  Charan
{
    void dheeraj();
    void amrit();
}
public interface ssr
{
    void RRR();
    void BB1();
}
public class vinod : Charan
{
    public void amrit()
    {
        Console.WriteLine("iam amrit");
    }

    public void dheeraj()
    {
        Console.WriteLine("i am dheeraj");
    }
}
public class movies : Charan, ssr
{
    public void amrit()
    {
        Console.WriteLine("pg");
    }

    public void BB1()
    {
        Console.WriteLine("I am bahubali"); 
    }

    public void dheeraj()
    {
        Console.WriteLine("iam dheeru"); 
    }

    public void RRR()
    {
        Console.WriteLine("iam RRR");
    }
}




