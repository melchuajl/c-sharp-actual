class Class1
{
    public virtual void Show()
    {

    }
}

class Demo : Class1
{
    public sealed override void Show()
    {
        base.Show();
    }
}

