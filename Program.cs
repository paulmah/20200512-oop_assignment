using System;

namespace oop_homework_assignment
{
    class Painting
    {
        public string Name = "Unknown";
        public string Artist = "Unknown Artist";
        public string Medium = "canvas";
        public int Year;
        public string MyPaintingname {
            get {
                return Name;
            } set {
                Name = value;
            }
        }
        public string MyArtist {
            get {
                return Artist;
            } set {
                Artist = value;
            }
        }
        public string MyMedium {
            get {
                return Medium;
            } set {
                Medium = value;
            }
        }
        public int MyYear {
            get {
                return Year;
            } set {
                Year = value;
            }
        }
        public virtual void polymorphism_test()
        {
            Console.WriteLine("Primary Object");
        }
    }
    class Painting_Inheritance : Painting
    {
        public string Painting_InheritanceTest = "louvre";
    }

    class MyPolymorphism_test : Painting
    {
        public override void polymorphism_test()
        {
            Console.WriteLine("Polymorphed test");
        }
    }

    class Program{ 
        static void Main(string[] args){
            Painting myPainting = new Painting();
            myPainting.Name = "mona";
            myPainting.Artist = "leo";
            myPainting.Medium = "canvas";
            myPainting.Year = 1960;
            Painting_Inheritance newPainting_Inheritance = new Painting_Inheritance();
            Painting MyPolyTest = new MyPolymorphism_test();

            Console.WriteLine("Paintingname: " + myPainting.MyPaintingname);
            Console.WriteLine("P: " + myPainting.Name);
            Console.WriteLine("A: " + myPainting.Artist);
            Console.WriteLine("M: " + myPainting.Medium);
            Console.WriteLine("Y: " + myPainting.Year);
            Console.WriteLine("M: " + newPainting_Inheritance.Name);
            Console.WriteLine("M: " + newPainting_Inheritance.Painting_InheritanceTest);
            MyPolyTest.polymorphism_test();
        }
    }
}