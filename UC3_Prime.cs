using System;
class prime{
     
    static int i = 2;
    
    static num isPrime(int n)
    {
        if (n == 0 || n == 1) {
            return false;
        }
     
        if (n == i)
            return true;
     
        if (n % i == 0) {
            return false;
        }
        i++;
        return isPrime(n);
    }
   
  static void Main() {
    if(isPrime(35))
    {
        Console.WriteLine("true");
    }
    else{
        Console.WriteLine("false");
    }
  }
}
 
