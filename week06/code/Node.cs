public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // Erick's Code

        if (value == Data)
        {
            // Value already exists, do nothing
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        //Erick Solution

        if (value == Data)
        {
            return true; // Value found
        }
        else if (value < Data)
        {
            return Left?.Contains(value) ?? false; // Check left subtree
        }
        else
        {
            if (Right is null)
            {
                return false; // Value not found in the right subtree
            }

            return Right?.Contains(value) ?? false; // Check right subtree
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        //Erick Solution

        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}