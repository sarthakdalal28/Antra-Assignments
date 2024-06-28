namespace Assignment03;

public class Ball
{
    public int Size { get; private set; }
    public Color Color { get; set; }
    private int throwCount;

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        throwCount = 0;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}