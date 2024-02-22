namespace dmkfamilydisp{

    class Mkstalin : Kalaingar {

        string Movableasset, Immovableassets;
        public Mkstalin(){
            Movableasset="5 Crore+";
            Immovableassets="3 Crore+";

        }

        public void MkstalinPersonal(){
            
            Console.WriteLine("Hi I am MK Stalin... ");
            Console.WriteLine("I have Son named Mr. Udhayanithi stalin");
            Console.WriteLine("I have daughter named Ms. Senthamarai");
   
        }
        public string getMovableasset(){
            return Movableasset;
        }
         public string getImmovableassets(){
            return Immovableassets;
        }

        



    }
}