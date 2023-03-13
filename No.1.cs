namespace Midterm1{
    class Midterm1{

        static void Main (string[]args) {

                Console.WriteLine("Please input x1:");
                double x1 =double.Parse(Console.ReadLine());
                Console.WriteLine("Please input y1");
                double y1 =double.Parse(Console.ReadLine());
                 Console.WriteLine("Please input w1:");
                double w1 =double.Parse(Console.ReadLine());
                Console.WriteLine("Please input h1");
                double h1 =double.Parse(Console.ReadLine());
                
                Console.WriteLine("Please input x2:");
                double x2 =double.Parse(Console.ReadLine());
                Console.WriteLine("Please input y2");
                double y2 =double.Parse(Console.ReadLine());
                 Console.WriteLine("Please input w2:");
                double w2 =double.Parse(Console.ReadLine());
                Console.WriteLine("Please input h2");
                double h2 =double.Parse(Console.ReadLine());

                double sumx1=x1+w1;
                double sumx1_2=x1-w1;
                double sumy1=y1+h1;
                double sumy1_2=y1-h1;

                double sumx2=x2+w2;
                double sumx2_2=x2-w2;
                double sumy2=y2+h2;
                double sumy2_2=y2-h2;

                double area1 = sumy1+(-sumy1_2)*sumx1+(-sumx1_2);


                double area2 = sumy2+(-sumy2_2)*sumx2+(-sumx2_2); 
                

                if((area1-area2)>8 && (area1-area2)<-8 ){
                     Console.WriteLine("Too Much Overlaping");
                }else{ 
                    if((area1-area2)<=8 && (area1-area2)>=-8 ){
                     Console.WriteLine("Not Much Overlapping");
                }else{
                    Console.WriteLine("No Overlapping");
                }
                
                }
                
                
               
                

                

                }
                


            





        } 
    }
  