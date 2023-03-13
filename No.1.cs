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

                int sumx1=(int)x1+(int)w1;
                int sumx1_2=(int)x1-(int)w1;
                int sumy1=(int)y1+(int)h1;
                int sumy1_2=(int)y1-(int)h1;

                int sumx2=(int)x2+(int)w2;
                int sumx2_2=(int)x2-(int)w2;
                int sumy2=(int)y2+(int)h2;
                int sumy2_2=(int)y2-(int)h2;

                int area1 = sumy1+(-sumy1_2)*sumx1+(-sumx1_2);


                int area2 = sumy2+(-sumy2_2)*sumx2+(-sumx2_2); 
                

                if((area1-area2)> 8 || (area1-area2)< -8 ){
                     Console.WriteLine("Too Much Overlaping");
                }else{ 
                    if((area1-area2)<=8 || (area1-area2)>=-8 ){
                     Console.WriteLine("Not Much Overlapping");
                }else{
                    if(!((area1-area2)<=8) && !((area1-area2)>=-8 ) && !((area1-area2)> 8) && !((area1-area2)< -8 )){
                     Console.WriteLine("No Overlapping");
                }
                    Console.WriteLine("No Overlapping");
                }
                
                }
                
                
               
                

                

                }
                


            





        } 
    }
  