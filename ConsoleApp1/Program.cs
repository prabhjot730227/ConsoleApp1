using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside Ontario = new Countryside();
            Ontario.run();
        }
    }
    class Village
    {
        
            public static int numberOfVillages = 0;
            public Village nextVillage;
            public Village previousVillage;
            public string VillageName;
            public bool isAstrildeHere = false;

            public Village() {
               Village.numberOfVillages++; }
        
    }

    class Countryside
    {
        public Village Maple;
        public Village Toronto;
        public Village Ajax;
        public Village Head;
        public Village Tail;
        public Village Temp;

        public void run()
        {
            this.MapInitializer();
            this.LookForAstrilde();
        }

        public void MapInitializer()

       
        {
            Maple = new Village();
            Maple.VillageName = "Maple";
            Maple.previousVillage = null;
            Maple.nextVillage = Toronto;
            Maple.isAstrildeHere = true;
            Toronto = new Village();
            Toronto.previousVillage = Maple;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Ajax = new Village();
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;
            //Ajax.isAstrildeHere = true;


        }
        public void LookForAstrilde()
        {
            Head = Maple;
            if (Head.isAstrildeHere)
            {
                Console.WriteLine("Yeah ! Astrilde is in " + Head.VillageName);            }


            //while (true)
            //{
                
            //}
        }
    }
}
