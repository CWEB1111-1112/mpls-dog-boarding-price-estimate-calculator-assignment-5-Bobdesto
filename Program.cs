using System;

namespace assignment_five
{
    class Program
    {
        static void Main(string[] args)
        {
          //DECLARATIONS
          string dogOwner, dogName, ServiceCode;
          double dogWeight,DAILY_RATE = 75.00, A_RATE = 169.00, C_RATE = 112.00;
          int numDays;
          double total=0;

          //creating an array of three estimate objects
          Estimate [] estimate = new Estimate[3];

          for(int x=0; x < estimate.Length; x++){

            //Create a three object instances of Estimate and output data using toString Method from Estimate class
            estimate[x] = new Estimate();

            Console.WriteLine("Please enter the Dog owner's name: ");
            dogOwner = Console.ReadLine();
            //
            estimate[x].DogOwner = dogOwner;

            Console.WriteLine("Please enter the dog's name: ");
            dogName = Console.ReadLine();
            //setting the value for the object instance
            estimate[x].DogName =dogName;

            Console.WriteLine($"Please enter {dogOwner} weight of dog: ");
            dogWeight= Convert.ToInt32(Console.ReadLine());
            //
            estimate[x].WeigtOfDog = dogWeight;

            Console.WriteLine("please enter the number of days the dog will stay at this location: ");
            numDays= Convert.ToInt32(Console.ReadLine());
            //
            estimate[x].NumDays= numDays;

          


          }
        }    
    }
    //Create a class called Estimate
    class Estimate
    {
      public string DogOwner{get; set;}
      public string DogName{get; set;}
      public double WeigtOfDog{get; set;}
      public int NumDays{get; set;}

      public string ServiceCode {get; set;}

      public override String ToString(){
            return String.Format($"Hi {DogOwner} Your Dog name is: {DogName} \n {WeigtOfDog}  Number of days is: {NumDays}");

      //working method to determine cost based on code - review first class example on Student object
      public void determineCost(){
          if(ServiceCode == "A" || ServiceCode == "C")){
                //
          
                Console.WriteLine("Sorry, invalid input. Make sure to enter A, N or C.");
      }
    }
}
