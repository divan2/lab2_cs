class ClassRoom
{

}

class Pupil
{
    virtual public void Study()
    {
        Console.WriteLine("He studies");
    }

    virtual public void Read() {
        Console.WriteLine("He reads")
    }

    public void Write() { 
    }

    public void Relax() { 
    }

}

class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("He studies perfectly");
    }

    public override void Read()
    {

    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("He studies normally");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("He studies badly");
    }
}
