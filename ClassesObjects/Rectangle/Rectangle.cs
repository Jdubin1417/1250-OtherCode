/*
    Recall that classes describe objects --
    both their data (fields) and their actions (methods)
*/
public class Rectangle
{
    // fields (data)
    private int length;
    private int width;

    // Constructors
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(int len, int wid)
    {
        // notice parameters are different names than the fields
        // this avoids the shadowing of the field names
        length = len;
        width = wid;
    }


    // methods (actions)
    public int GetLength()
    {
        return length;
    }

    public int GetWidth()
    {
        return width;
    }

    public void SetLength(int length)
    {
        // this.length refers to the field value of length (not the parameter)
        this.length = length;
    }

    public void SetWidth(int width)
    {
        // this.width refers to the field value of width (not the parameter)
        this.width = width;
    }

    public int GetArea()
    {
        int area = length * width;
        return area;
    }
}