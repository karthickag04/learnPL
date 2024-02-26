using System;


 public interface Drawable{
       void draw();
    }

    
 public interface SetDrawable{
       void SetColour();
    }

    public class Circle : Drawable, SetDrawable
    {
        public void draw(){
            Console.WriteLine("I can Draw circle");
        }
         public void SetColour(){
            Console.WriteLine("I can set circle colour as black");
        }

        
    }


    
    public class Rectangle : Drawable{
        public void draw(){
            Console.WriteLine("I can Draw Rectangle");
        }
    }

        public class Square : Drawable{
        public void draw(){
            Console.WriteLine("I can Draw Square");
        }
    }

         public class Line : Drawable{
        public void draw(){
            Console.WriteLine("I can Draw Line");
        }
    }





namespace interfacedemo{
 


public class Shape{

    public static void Main(){

        Drawable d;
        SetDrawable sd;
        
        d=new Circle();
        d.draw();

        sd=new Circle();
        sd.SetColour();
       
        d=new Square();
        d.draw();
        d=new Rectangle();
        d.draw();
        d=new Line();
        d.draw();
        Console.ReadLine();
        Line l=new Line();
        l.draw();


    }
}


}