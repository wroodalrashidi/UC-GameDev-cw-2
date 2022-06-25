



class program
{

    static void Main(string[] args)
    {


        //cw - if statment 

        ////hero
        string heroName = "bedour";
        int heroPower = 70;

        ////villian
        string villainName = "wrood";
        int villainPower = 100;



        if(heroPower > villainPower)
        {
            Console.WriteLine("Hero is stronger");
        }

        else if(heroPower < villainPower)
        {
            Console.WriteLine("Villian is stronger");
        }

        else
        {
            Console.WriteLine("Same level");
        }



      
        // cw - functions 
        double playerSpeed = 5.0;
        double newSpeed = 2.5;
        double oldSpeed = 5.0;

        SetSpeed(newSpeed);


        void SetSpeed(double newSpeed)
        {
            playerSpeed = newSpeed;

            Console.WriteLine(oldSpeed);
            Console.WriteLine(newSpeed);
        }


        // cw - bonus 
        CompareSpeed(oldSpeed, newSpeed);


        void CompareSpeed(double oldSpeed, double newSpeed)
        {
            if(newSpeed > oldSpeed)
            {
                Console.WriteLine("New speed is bigger, which is " + newSpeed);
            }

            else if (oldSpeed > newSpeed)
            {
                Console.WriteLine("Old speed is bigger, which is " + oldSpeed);
            }

            else
            {
                Console.WriteLine("Old speed " + oldSpeed + ", and new speed " + newSpeed + ", are the same ");
            }
        }





    }

}




