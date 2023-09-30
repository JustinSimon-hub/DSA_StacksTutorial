//notes gonna be taken after  the video in docs

/*
 STACK TUTORIALLLL
 */


using DSA_StacksTutorial;

Sttack stack = new Sttack(10);

for(int i = 0; i < 3; i++)
{
    stack.Push("Hi");
    stack.Push("Hello");
    stack.Push("Greeting");
}

stack.Pop();

stack.Peek();

while (!stack.isEmpty())
{
    var var = stack.Pop();
    Console.WriteLine("********");
    Console.WriteLine(var);
}