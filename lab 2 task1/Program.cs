using System.Diagnostics.Contracts;

class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("The pupil is studying.");
    }

    public virtual void Read()
    {
        Console.WriteLine("The pupil is reading.");
    }

    public virtual void Write()
    {
        Console.WriteLine("The pupil is writing.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("The pupil is relaxing.");
    }
}

class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("The excelent pupil studies very well.");
    }

    public override void Read()
    {
        Console.WriteLine("The excelent pupil reads a lot.");
    }
    public override void Write()
    {
        Console.WriteLine("The excelent pupil writes excellent essays.");
    }
    public override void Relax()
    {
        Console.WriteLine("The excelent pupil relaxes by doing extra homework.");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("The good pupil studies diligently.");
    }
    public override void Read()
    {
        Console.WriteLine("The good pupil enjoys reading books.");
    }
    public override void Write()
    {
        Console.WriteLine("The good pupil writes neat papers.");
    }
    public override void Relax()
    {
        Console.WriteLine("The good pupil relaxes by playing educational games.");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("The bad pupil is struggling with studies.");
    }
    public override void Read()
    {
        Console.WriteLine("The bad pupil finds reading difficult.");
    }
    public override void Write()
    {
        Console.WriteLine("The bad pupil has messy handwriting.");
    }
    public override void Relax()
    {
        Console.WriteLine("The bad pupil relaxes by skipping homework.");
    }
}

class ClassRoom
{
    private Pupil[] pupils;
    public ClassRoom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }
    public void GetPupils()
    {
        for(int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
        }
    }
}

class Program
{
    static void Main()
    {
        Pupil pupil1 = new ExcelentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new GoodPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.GetPupils();

    }
}